using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    // Structs are almost the same as classes
    public struct Student
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Print()
        {
            Console.WriteLine($"ID: {_id} Name: {_name}");
        }

        public Student(int Id, string name)
        {
            _id = Id;
            _name = name;
        }
    }

    class Structures
    {
        static void Main(string[] args)
        {
            // Object Initializer Syntax
            Student student = new Student
            {
                ID = 101,
                Name = "Harvey"
            };
        }
    }
}
