using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public class OrderDressInfo
    {
        public string DressName { get; set; }

        public string Color { get; set; }

        public string Size { get; set; } // S, M, L, XL

        public int Quantity { get; set; }  // > 0
    }
}
