using System;
using System.Reflection;

namespace Reflections
{
    public class Reflections
    {
        public static void Main(string[] args)
        {
            //Reflection is nothing but only an inspection of assemblies' metadata at runtime
            Type type = typeof(Customer);

            //By using reflection we can retrieve the name of the namspace, name of class and the fully qualified name
            Console.WriteLine("Fully qualified name: {0}", type.FullName);
            Console.WriteLine("Class Name: {0}", type.Name);
            Console.WriteLine("Namespace: {0}", type.Namespace);

            //By using reflection we can retrieve information about the properties of a class
            Console.WriteLine("\nProperties in Customer Class:");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }

            //By using reflection we can retrieve information about the method of a class
            //Additionally, you will find that there are more methods that appears here,
            //that is because property fields are actually using getter and setter methods behind the scenes,
            //and all classes are inheriting methods from the base class System.Object behind the scenes.
            Console.WriteLine("\nMethods in Customer Class:");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }

            //By using reflection we can retrieve information about them Constructors of a class
            Console.WriteLine("\nConstructors in Customer Class:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    public class Customer
    {
        //Fields
        public int Age { get; set; }
        public string Name { get; set; }

        //Constructors
        public Customer()
        {

        }

        public Customer(int a, int b)
        {

        }

        //Methods
        public void PrintAge()
        {

        }

        public void PrintName()
        {

        }
    }
}
