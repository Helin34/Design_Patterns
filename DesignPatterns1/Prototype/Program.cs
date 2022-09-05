using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Firstname = "Helin", Lastname = "Çelikbaş", City = "Konya", ID = 1 };
            Console.WriteLine(customer1.Firstname);
            var customer2 = (Customer)customer1.Clone();
            customer2.Firstname = "Salih";
            Console.WriteLine(customer1.Firstname);
            Console.WriteLine(customer2.Firstname);
            Console.ReadLine();
        }
    }
    public abstract class Person
    {
        public abstract Person Clone();
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }


    }
    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();

        }
    }
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();

        }
    }
}
