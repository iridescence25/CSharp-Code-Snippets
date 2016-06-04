using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public class Enumerations
    {
        public static void Main(string[] args)
        {
            //How to get values contained in the enum
            short[] values = (short[])Enum.GetValues(typeof(Gender));

            foreach (short value in values)
            {
                Console.WriteLine(value);
            }

            //How to get symbolic names in the enum
            string[] names = Enum.GetNames(typeof(Gender));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

    //You can change the underlying default data type (int), in this example: short
    //You can also change the values, it doesn't matter if its not sequential as long as it follows the limits of the data type used.
    public enum Gender : short
    {
        Unknown = 1,
        Male = 5,
        Female = 23
    }
}
