using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildQtyTracker
{
    internal class SKU
    {
        public string SKU_Value { get; }
        public int SKU_ID { get; }
        public SKU(string SKU_Value,int SKU_ID )
        {
            this.SKU_Value = SKU_Value;
            this.SKU_ID = SKU_ID;
        }
    }
}
