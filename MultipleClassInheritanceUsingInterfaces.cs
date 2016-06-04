using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassInheritanceUsingInterfaces
{
    interface ICustomerA
    {
        void PrintA();
    }

    interface ICustomerB
    {
        void PrintB();
    }

    //Class inherits from Interface
    class CustomerA : ICustomerA
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA");
        }
    }

    //Class inherits from Interface
    class CustomerB : ICustomerB
    {
        public void PrintB()
        {
            Console.WriteLine("PrintB");
        }
    }

    //Class inherits from Interfaces which enables the capability to inherit methods from other classes at the same time.
    class CustomerAB : ICustomerA, ICustomerB
    {
        CustomerA cA = new CustomerA();
        CustomerB cB = new CustomerB();

        public void PrintA()
        {
            cA.PrintA();
        }

        public void PrintB()
        {
            cB.PrintB();
        }
    }


    class MultipleClassInheritanceUsingInterfaces
    {
        static void Main(string[] args)
        {
            //Call methods from the first two classes using methods of the child class
            CustomerAB cAB = new CustomerAB();
            cAB.PrintA();
            cAB.PrintB();
        }
    }
}
