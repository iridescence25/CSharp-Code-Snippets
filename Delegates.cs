using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Delegates
    {
        //Delegates are similar to methods and classes (They point to a function/method)
        public delegate void PrintDelegate(string message);

        public static void Main(string[] args)
        {
            //Create an instance of the delegate
            PrintDelegate pD = new PrintDelegate(Print);
            pD("Hello World! ~ From Delegate");
        }

        //In order to use methods for delagetes, it must have the same signature: return type and parameters
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
