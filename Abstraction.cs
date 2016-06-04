using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // An abstract class can only be a base class.
    public abstract class Customer
    {
        //Abstract member
        public abstract void Print();

        //Non-abstract member
        public void Show()
        {
            Console.WriteLine("Show.");
        }
    }

    //A non-abstract class that inherits the abstract class must provide implementation for abstract members of the abstract class.
    //Or, mark the non-abstract class as abstract.
    public class Abstraction : Customer 
    {
        //Use Override keyword to use the Print method of the abstract class.
        public override void Print()
        {
            Console.WriteLine("Print.");
        }

        public static void Main(string[] args)
        {
            Customer program = new Abstraction();
            program.Print();
            program.Show();
        }
    }
}
