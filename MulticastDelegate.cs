using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class MulticastDelegate
    {
        //Multicast Delagate enables to reference on more than one method with the same signature.
        //On methods with return types, only the last method's return value is retrieved by the delegate.
        //Same applies with the out keyword.
        public delegate void SampleDelegate();

        public static void Main(string[] args)
        {
            //Use += operator to register methods to a delegate.
             
            SampleDelegate del = new SampleDelegate(Method1);
            del += Method2;
            del += Method3;

            //Multicast Delegate
            del();

            //Can also use + or - sign, but we need to create an instance of delegate per method.
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(Method1);
            //del2 = new SampleDelegate(Method2);
            //del3 = new SampleDelegate(Method3);

            //Multicast delegate
            //del4 = del1 + del2 + del3;
        }

        public static void Method1()
        {
            Console.WriteLine("Print1.");
        }

        public static void Method2()
        {
            Console.WriteLine("Print2.");
        }

        public static void Method3()
        {
            Console.WriteLine("Print3.");
        }
    }
}
