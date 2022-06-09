using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class StockAccount :Account
    {
        private string stock;
        private int amount;
        private int price;

        public StockAccount(string bank, string id, string name, int balance, string stock, int amount, int price) : base(bank, id, name, balance)
        {
            this.stock = stock;
            this.amount = amount;
            this.price = price;
        }

        public void sell(int amount, int price)
        {
             this.amount -= amount;
             base.balance += amount * price; //base 넣어주는건 그냥 부모클래스쪽으이 변수인걸 알기쉽게 표시해둔것.
        }
        
        public void buy(int amount, int price)
        {
            this.amount += amount;
            base.balance -= amount * price;
        }
        
        public void Show()
        {
            Console.WriteLine("==================");
            base.Show();
            Console.WriteLine("주식명"+ stock);
            Console.WriteLine("주식수량"+ amount);
            Console.WriteLine("주식가격"+price);
            Console.WriteLine("==================");
        }
    }
}
