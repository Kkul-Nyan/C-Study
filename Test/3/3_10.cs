using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    interface Buyer
    {
        public abstract void Buy();
    }

    interface Seller
    {
        public abstract void Sell();
    }

    class customers : Buyer, Seller
    {
        public void Sell()
        {
            Console.WriteLine("판매하기");
        }
        
        public void Buy()
        {
            Console.WriteLine("구맴하기");
        }
    }
    internal class _3_10
    {
        static void Main1(string[] args)
        {
            Buyer buyer = new customers();
            Seller seller = new customers();

            buyer.Buy();
            seller.Sell();
        }
    }
}
