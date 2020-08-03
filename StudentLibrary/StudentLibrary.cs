using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        private int studentId;
        private string studentName;
        private float studentSalary;

        public void acceptDetails()
        {
            Console.WriteLine("studentId + studentName + studentSalary");
            this.studentId = int.Parse(Console.ReadLine());//this represent current class
            this.studentName = Console.ReadLine();
            this.studentSalary = Convert.ToSingle(Console.ReadLine());
        }
        public void displayDetails()
        {
            Console.WriteLine("{0}---{1}------{2}", studentId, studentName, studentSalary);
            Console.ReadKey();
        }
    }
}
