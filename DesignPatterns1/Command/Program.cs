using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // hello Word
            // hello Word2

        }
    }
    class StockManager
    {
        private string _name ="Laptop";
        private int _quantity = 10;
        public void Buy()
        {
            Console.WriteLine("Stock: {0},{1} bought! ", _name, _quantity);
        }
        public void Sell()
        {
            Console.WriteLine("Stock: {0},{1} bought!", _name, _quantity);
        }
    }
   interface  IOrder
    {
        void Execute();

    }
    class BuyStok
    {

    }
    class StockController
    {
        List<IOrder> orders = new List<IOrder>();
        private object _orders;

        public void TakeOrder()
        {
            _orders.Add();
        }
    }
}
