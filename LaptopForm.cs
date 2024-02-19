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
    public partial class LaptopForm : Form
    {
        Laptops laptops;
        public LaptopForm()
        {
            InitializeComponent();
            laptops = new Laptops();
            laptopDropdown.DataSource = laptops.getModelList();
            laptopDropdown.Refresh();
            skuCombobox.DataSource = laptops.getSKUs(laptopDropdown.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Laptop laptop=new Laptop(SKU_textbox.Text,Model_TextBox.Text,CPU_TextBox.Text,Memory_Texbox.Text,SSD_TextBox.Text,
                Screen_TextBox.Text,Colour_TextBox.Text,Grade_Textbox.Text);
            laptops.addLaptop(laptop);
            laptopDropdown.DataSource= laptops.getModelList();
            laptopDropdown.Refresh();


        }

        private void swapLaptop(object sender, EventArgs e)
        {
            Laptop laptop=laptops.getLaptop(skuCombobox.Text);
            try
            {
                SKU_textbox.Text = laptop.SKU;
                Model_TextBox.Text = laptop.model;
                CPU_TextBox.Text = laptop.cpu;
                Memory_Texbox.Text = laptop.memory;
                SSD_TextBox.Text = laptop.storage;
                Screen_TextBox.Text = laptop.screen;
                Colour_TextBox.Text = laptop.colour;
                Grade_Textbox.Text = laptop.grade;
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        private void changeSKUs(object sender, EventArgs e)
        {
            skuCombobox.DataSource = laptops.getSKUs(laptopDropdown.Text);
            skuCombobox.Refresh();
        }
    }
}
