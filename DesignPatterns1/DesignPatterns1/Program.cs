using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns1
{
    class Program
    {
        
        static void Main(string[] args)
        {
          var customerMeneger= CustomerMeneger.CreateAsSingleton();
            customerMeneger.Save();
            {

            }
           
        }
    }
    class CustomerMeneger
    {
        private static CustomerMeneger _customerMeneger;
        static object _lockObject= new object();
        private CustomerMeneger()
        {

        }

        public static CustomerMeneger CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if(_customerMeneger== null)
                {
                    _customerMeneger = new CustomerMeneger();
                }
            }
            return _customerMeneger;
        }
        public void Save()
        {
            Console.WriteLine("Saved!");
        }

    }
}
