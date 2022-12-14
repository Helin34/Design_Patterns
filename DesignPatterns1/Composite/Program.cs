using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee helin = new Employee { Name = "Helin Çelikbaş" };
            Employee engin = new Employee { Name = "Engin Demiroğ" };
            helin.AddSubordinate(engin);
            Employee derin = new Employee { Name = "Derin Demiroğ" };
            helin.AddSubordinate(derin);
            Contractor ali = new Contractor { Name = "Ali" };
             derin.AddSubordinate(ali);


           
            Employee fatma = new Employee { Name = "Fatma Kaya" };
            engin.AddSubordinate(fatma);
            Console.WriteLine(helin.Name);
            foreach (Employee manager in helin)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("  {0}",employee.Name);
                }
            }

            Console.ReadLine();

        }

    }
    interface IPerson
    {
         string Name { get; set; }


    }
    class Contractor:IPerson
    {
        public string Name { get; set; }
    }
        class Employee : IPerson, IEnumerable<IPerson>
        {
            List<IPerson> _subordinates = new List<IPerson>();

            public void AddSubordinate(IPerson person)
            {
                _subordinates.Add(person);
            }
            public void RemoveSubordinate(IPerson person)
            {
                _subordinates.Remove(person);
            }
            public IPerson GetSubordinate(int index)
            {
                return _subordinates[index];
            }
            public string Name { get; set; }

            public IEnumerator<IPerson> GetEnumerator()
            {
                foreach (var subordinates in _subordinates)
                {
                    yield return subordinates;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        
    }
}
