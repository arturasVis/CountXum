using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildQtyTracker
{
    internal class Laptop
    {
        public string SKU, model, cpu, memory, storage, screen, colour, grade, serial;
        public Laptop(string SKU, string model, string cpu, string memory,string storage, string screen, string colour, string grade, string serial)
        {
            this.SKU = SKU;
            this.model = model;
            this.cpu = cpu;
            this.memory = memory;
            this.storage = storage;   
            this.screen = screen;
            this.colour = colour;
            this.grade = grade;
            this.serial = serial;

        }

        public void Save()
        {

        }
    }
}
