using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithReUsableClass
{
    public class DelegatesWithReUsableClass
    {
        public static void Main(string[] args)
        {
            //Generics
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { ID = 001, Name = "Harvey", Salary = 100000, Experience = 10 });
            employeeList.Add(new Employee() { ID = 002, Name = "Yumi", Salary = 100000, Experience = 8 });
            employeeList.Add(new Employee() { ID = 003, Name = "Yugito", Salary = 50000, Experience = 4 });
            employeeList.Add(new Employee() { ID = 004, Name = "Yuki", Salary = 1000000, Experience = 2 });

            //Create an instance of the delegate. In the constructor, the target method must be specified
            IsPromotable promotable = new IsPromotable(Promote);

            //Pass paramaters with delegate to the method of another class that must be re-used
            Employee.PromoteEmployee(employeeList, promotable);
        }

        //When this method is invoked by the delegate, this would receive the employee variable to make it undergo some kind of logic
        //and return a boolean
        public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Delegate must have the same signature as the method to be invoked. (Same return type and parameter)
    public delegate bool IsPromotable(Employee empl);

    //Class Employee
    public class Employee
    {
        //Auto-implemented properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //To make a method reusable, use delagate as one of its parameters
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                //Whent this code is invoked, this automatically points to the method created in the Program class named: Promote(Employee emp).
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine($"{employee.Name} promoted.");
                }
            }
        }

    }
}
