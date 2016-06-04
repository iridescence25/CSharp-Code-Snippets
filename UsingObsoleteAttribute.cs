using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingObsoleteAttribute
{
    public class UsingObsoleteAttribute
    {
        public static void Main(string[] args)
        {
            //By setting a method obsolete, you can tell the user of the code if there's a new version of the method.
            //This line would show compiler warning.
            Console.WriteLine(Calculator.Add(1, 2));

            //New method
            Console.WriteLine(Calculator.Add(new List<int> { 1, 51, 25 }));
        }
    }

    public class Calculator
    {
        //Obsolete method
        //Instead of removing old method, you use obsolete instead so that you won't break the applications of users when they update to the latest version of your class
        [Obsolete("Use Add(List<int> numbers) method instead.")]
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //New method
        public static int Add(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
