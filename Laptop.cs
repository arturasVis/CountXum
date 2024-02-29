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
        public string SKU { get; }
        public string model { get; } 
        public string cpu { get; }
        public string memory { get; }
        public string storage { get; }
        public string screen { get; }
        public string colour { get; }
        public string grade { get; }
        public string windows { get; }
        public Laptop(string SKU, string model, string cpu, string memory,string storage, string screen, string colour, string grade,string windows)
        {
            this.SKU = SKU;
            this.model = model;
            this.cpu = cpu;
            this.memory = memory;
            this.storage = storage;   
            this.screen = screen;
            this.colour = colour;
            this.grade = grade;
            this.windows = windows;
        }
    }
}
