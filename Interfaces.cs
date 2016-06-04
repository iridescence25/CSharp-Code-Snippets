using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Interfaces cannot have fields and implementations, only declarations.
    interface ICustomer1
    {
        void print1();
    }

    //Interfaces can inherit from other interfaces
    interface ICustomer2 : ICustomer1
    {
        void print2();
    }

    interface I1
    {
        void interfaceMethod();
    }

    interface I2
    {
        void interfaceMethod();
    }

    //Classes must provide implementations for the interfaces inherited
    public class Customer : ICustomer2
    {
        public void print1()
        {
            Console.WriteLine("Print1");
        }

        public void print2()
        {
            Console.WriteLine("Print2");
        }
    }

    //Classes can inherit more than one interface
    class Interfaces : I1, I2
    {
        //Default interface implementation
        public void interfaceMethod()
        {
            Console.WriteLine("Interface 1");
        }

        //Explicit interface implementation
        void I2.interfaceMethod()
        {
            Console.WriteLine("Interface 2");
        }

        static void Main(string[] args)
        {
            //Interface can be used as reference object variable to point to an object of a class in the heap
            ICustomer1 customer = new Customer();
            customer.print1();


            Interfaces program = new Interfaces();
            program.interfaceMethod();

            //Type casting is needed to call explicit interface implementation
            ((I2)program).interfaceMethod();
        }
    }
}
