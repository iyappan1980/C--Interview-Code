using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewCode
{
    public class EnumerableClass
    {
        // IEnumerable in C# is an interface that defines one method, GetEnumerator which returns an IEnumerator interface.
        // This allows readonly access to a collection then a collection that implements IEnumerable can be used with a for-each statement.
        public class Customer{
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }

        Customer[] customers = new Customer[]
        {
            new Customer{Name = "Kin",Age=20,City="London"},
            new Customer{Name = "Star",Age=20,City="Chennai"},
            new Customer{Name = "Raji",Age=20,City="Sutton"},
        };
        
        public IEnumerable<Customer> GetCustomers() { return customers; }
        
        public void GetAllCustomer()
        {
            foreach (var cust in GetCustomers())
            {
                Console.WriteLine(cust.Name + " " + cust.Age + " " + cust.City);
            }
        }
    }
}
