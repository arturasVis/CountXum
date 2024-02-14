using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace BuildQtyTracker
{
    public partial class LaptopForm : Form
    {
        public LaptopForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\PC\\Desktop\\CountXum\\save.JSON";
            Laptop laptop = new Laptop(SKU_textbox.Text,Model_TextBox.Text,CPU_TextBox.Text,Memory_Texbox.Text,SSD_TextBox.Text,Screen_TextBox.Text,Colour_TextBox.Text,Grade_Textbox.Text,SN_TextBox.Text);
            List<Laptop> laptops = new List<Laptop>();
            if(File.Exists(path) )
            {
                string existingJson= File.ReadAllText(path);

                laptops= JsonConvert.DeserializeObject<List<Laptop>>(existingJson) ?? new List<Laptop>();
            }
            else
            {
                laptops=new List<Laptop>();
            }
            laptops.Add(laptop);
            string JSonString=JsonConvert.SerializeObject(laptops,Formatting.Indented);

            File.WriteAllText("C:\\Users\\PC\\Desktop\\CountXum\\save.JSON",JSonString);


        }
    }
}
