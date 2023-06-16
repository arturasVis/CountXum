using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildQtyTracker
{
    public partial class Form1 : Form
    {
        static private int count;
        static private Settings1 settings = new Settings1();
        static private SheetsClass sheets = new SheetsClass("Desktop Application 1", "17ZA5GDt2SadFFgdNoA3rtCPNJ6kE9D4ojA9BFU6NjaQ");
        static private List<SKU> list = new List<SKU>();
        static private ZebraLabelPrinter zebra = new ZebraLabelPrinter("ZEBRA");
        static private DBManager dBManager = new DBManager();
        public Form1()
        {
            InitializeComponent();
            sheets.Authentication();
            ChangeState(settings.State);
            qty_Label.Text = settings.Count.ToString();
            count = settings.Count;
            list = ReadSkus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                settings.Count = 0;
                count=0;
                settings.Save();
                ChangeState("n");
                qty_Label.Text = settings.Count.ToString();
            }
            else
            {
                MessageBox.Show("Check the box to reset");
            }

        }
        private void ChangeState(string state)
        {
            if (state == "p")
            {
                Label_Top_Left.Text = settings.SKU;
                New_Prebuild_Button.Visible = true;
                orderId_box.Visible = false;
                Label_Top_Left.Focus();
                settings.State = "p";
                settings.Save();
            }
            else
            {
                Label_Top_Left.Text = "Order Id";
                New_Prebuild_Button.Visible= false;
                orderId_box.Visible = true;
                orderId_box.Focus();
                settings.State = "n";
                settings.Save();
            }
        }
        private string OrderIDManager(string orderId)
        {
            string value=orderId;
            foreach (SKU sku in list)
            {
                if (sku.SKU_ID==Int32.Parse(orderId.Trim()))
                {
                    value = sku.SKU_Value;
                    settings.SKU = value;
                    settings.Save();
                    ChangeState("p");
                    break;
                }
            }
            return value;
        }
        private void Keydown(object sender, KeyEventArgs e)
        {
            if (settings.State == "p")
            {
                if (e.KeyCode == Keys.NumPad1)
                {
                    Execute(settings.SKU,1);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(orderId_box.Text))
                {
                    Execute(OrderIDManager(orderId_box.Text),1);
                    orderId_box.Clear();
                }
            }
        }
        private void Execute(string orderId,int n)
        {
            try
            {
                if (!String.IsNullOrEmpty(orderId))
                {
                    for(int i=0;i<n;i++)
                    {
                        List<object> list = new List<object>();
                        List<object> date = new List<object>();
                        list.Add(orderId);
                        list.Add(DateTime.Now.ToString("dd/MMM/yy"));
                        var dt = dBManager.SelectSpecific("History", "Channel", "Prebuilt");
                        string pId = "P" + $"{dt.Rows.Count}";
                        sheets.UpdateSheet(list, "Built Orders", "!A2", "A");
                        dBManager.InsertQuerry($"INSERT INTO History(Orderid,SKU,QTY,CHannel) VALUES " +
                                    $"('{pId}','{orderId}','1','Prebuilt')");
                        zebra.PrintLabelWithText(pId, orderId, 1);
                        count++;
                        settings.Count = count;
                        settings.Save();
                        qty_Label.Text = count.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No order ID");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private List<SKU> ReadSkus()
        {
            List<SKU> skus=new List<SKU>();
            
            string path = Application.StartupPath + "\\SKUS.csv";
            if (File.Exists(path))
            {
                string line = string.Empty;
                using (StreamReader sr = new StreamReader(path))
                {
                    do 
                    {
                        line = sr.ReadLine();
                        if(!String.IsNullOrEmpty(line))
                        {
                            string[] parts = line.Split(new char[] { '\t' });
                            string skup = parts[0];
                            int idp=int.Parse(parts[1]);
                            skus.Add(new SKU (skup,idp));
                        }
                               
                    }
                    while(!String.IsNullOrEmpty(line));
                }
            }
            return skus;
        }

        private void New_Prebuild_Button_Click(object sender, EventArgs e)
        {
            ChangeState("n");
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            if(settings.State== "p")
            {
                Execute(settings.SKU,Int32.Parse(Print_amount_textbox.Text));
            }
            else
            {
                MessageBox.Show("Set SKU first!");
            }
        }
    }
}
