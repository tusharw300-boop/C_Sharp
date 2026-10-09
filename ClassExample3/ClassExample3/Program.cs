
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Student student1 = new Student("John Doe", 20, "Sophomore");
            
            student1.DisplayStudentInfo();
            //student1 = null; hi i am tuahr wagh and also tush 

            Student student2 = new Student("Jane Smith", 22, "Senior");
            student1 = student2;

            student1.DisplayStudentInfo();

            student2 = null;

            student2.DisplayStudentInfo();
        }
    }
}
