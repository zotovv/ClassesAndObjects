using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    class Invoice
    {
        public readonly int account;
        public readonly string customer, provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CostCalculation(bool needNds)
        {
            double cost;
            switch(Article)
            {
                case "laptop": cost= 5400;
                    break;
                case "SD-cadr": cost = 32;
                    break;
                case "USB-hub": cost = 12;
                    break;
                default: Console.WriteLine("Нет такой информации.");
                    return;
            }
            if(needNds)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Сумма оплаты: {0}$", cost * Quantity);
        }
    }

}
