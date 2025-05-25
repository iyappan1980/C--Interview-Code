using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    internal class DependencyInjuction
    {
        // Dependency Injection is a technique where an object receives its dependencies from an external source rather than creating them itself.
        // This external source is typically a framework or container that manages the lifecycle and dependencies of objects.
        //Constructor Injection: Dependencies are provided through a class constructor.
        //Property Injection: Dependencies are provided through public properties of the class.
        //Method Injection: Dependencies are provided through method parameters.
    }
    public interface ICustomer
    {
        public void GetCustomer(string msg);

    }
    public class Customer : ICustomer
    {
        public void GetCustomer(string msg)
        {
            Console.WriteLine(msg);

        }
    }
    public class DependencyInjConstructor
    {
        private readonly ICustomer _customer;
        DependencyInjConstructor(ICustomer customer)
        {
            _customer = customer;
        }
        public void GetProcessCustomer(string msg) { 
            _customer.GetCustomer(msg);
        }
    }

    public class DependencyInjProperty
    {
        public ICustomer objCust { get; set; }
        public void GetProcessCustomer(string msg)
        {
            objCust.GetCustomer(msg);
        }
    }
    public class MethodInjectedProcessor
    {
        public void Process(string message, ICustomer messageService)
        {
            messageService.GetCustomer(message);
        }
    }

}
