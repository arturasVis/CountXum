using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildQtyTracker
{
    public partial class Form1 : Form
    {
        static private string path;
        static private int count=0;
        static private Settings1 settings=new Settings1();
        static private SheetsClass sheets = new SheetsClass("Desktop Application 1", "17ZA5GDt2SadFFgdNoA3rtCPNJ6kE9D4ojA9BFU6NjaQ", path);
        public Form1()
        {
            InitializeComponent();
            sheets.Authentication();
            qty_Label.Text = settings.Setting.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                settings.Setting = 0;
                settings.Save();
                qty_Label.Text = settings.Setting.ToString();
            }
            else
            {
                MessageBox.Show("Check the box to reset");
            }    
            
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(orderId_box.Text))
                {
                    List<object> list = new List<object>();
                    List<object> date=new List<object>();
                    list.Add(orderId_box.Text);
                    list.Add(DateTime.Now.ToString("dd/MMM/yy"));
                    sheets.UpdateSheet(list, "Built Orders", "!A2", "A");
                    count++;
                    settings.Setting = count;
                    settings.Save();
                    qty_Label.Text = count.ToString();
                }
                else
                {
                    MessageBox.Show("No order ID");
                }

            }
        }
    }
}
