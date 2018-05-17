using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(944578, "Alex", "Foxtrot") { Article = "USB-hub", Quantity = 6 };

            inv.CostCalculation(true);
            inv.CostCalculation(false);

            Console.ReadKey();
            
        }
    }
}
