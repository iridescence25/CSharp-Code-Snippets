using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    //Epmployee class that gets and sets name and gender for each object of the class
    public class Employee
    {
        public string name { get; set; }
        public Gender gender { get; set; }
    }

    //Enums are basically lists or enumeration of names, in which, they are used to maintain readability and maintability
    //Enums usually goes with Switch statements.
    //Default underlying data type is int.
    public enum Gender
    {
        Female,
        Male,
        Unknown
    }

    public class Enums
    {
        public static void Main(string[] args)
        {
            //Generics
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { name = "Harvey", gender = Gender.Male });
            employeeList.Add(new Employee() { name = "Yumi", gender = Gender.Female });
            employeeList.Add(new Employee() { name = "Yugito", gender = Gender.Unknown });

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"Name: {employee.name}, Gender: {GetGender(employee.gender)}");
            }
        }

        //Enums are much effective with Switch statements, in which we can specify proper names to cases and have a meaningful logic on each of them
        //Here, if female enum is selected, a logic under female case is invoked. In this case, returning a string.
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Female:
                    return "Female";
                case Gender.Male:
                    return "Male";
                case Gender.Unknown:
                    return "Unknown";
                default:
                    return "Invalid data.";
            }
        }
    }
}
