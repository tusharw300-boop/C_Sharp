using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample3
{
    internal class Student
    {
        string name;
        int age;
        string standard;

        public
            Student(string name, int age, string standard)
        {
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Standard: " + standard);
        }

    }
}
