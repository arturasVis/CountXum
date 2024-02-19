using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BuildQtyTracker
{
    internal class Laptops
    {
        private List<Laptop> laptopList = new List<Laptop>();
        private string path = Application.StartupPath + "\\save.JSON";

        public Laptops()
        {
            readJSON();
        }

        public void readJSON()
        {
            
            List<Laptop> laptops = new List<Laptop>();
            if (File.Exists(path))
            {
                try {
                    string existingJson = File.ReadAllText(path);

                    laptopList = JsonConvert.DeserializeObject<List<Laptop>>(existingJson) ?? new List<Laptop>();

                    Console.WriteLine(laptopList.Count);
                } catch { }
                
            }
            else
            {
                laptopList = new List<Laptop>();
            }
        }

        public List<string> getModelList()
        {
            List<string> list = new List<string>();
            foreach (var item in laptopList)
            {
                if(!list.Contains(item.model))
                {
                    list.Add(item.model);

                } 
            }
            return list;
        }
        public Laptop getLaptop(string SKU)
        {
            Laptop laptop=null;
            foreach (var item in laptopList)
            {
                if(item.SKU.Equals(SKU))
                {
                    laptop = item;
                }
            }
            return laptop;
        }
        public void addLaptop(Laptop newLaptop)
        {
            if(!laptopList.Exists(laptop => laptop.SKU == newLaptop.SKU))
            {
                laptopList.Add(newLaptop);
                string updatedJson = JsonConvert.SerializeObject(laptopList, Formatting.Indented);
                File.WriteAllText(path, updatedJson);
            }
        }
        public List<string> getSKUs(string model)
        {
            var list = new List<string>();
            foreach(var item in laptopList)
            {
                if (item.model.Equals(model))
                {
                    list.Add(item.SKU);
                }
            }
            return list;
        }
    }
}
