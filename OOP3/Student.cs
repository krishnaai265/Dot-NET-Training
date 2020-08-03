using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Student
    {
        
        private int studentId;
        private string studentName;
        private float studentSalary;
        static string organization_name;
        public Student() {
            organization_name = "Sopra Steria";
        }
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
    class Marks:Student {
        int om;
        public void acceptDetails()
        {
            Console.WriteLine("om");
  //          base.acceptDetails();
            this.om = int.Parse(Console.ReadLine());
        }
        public void displayDetails()
        {
  //          base.displayDetails();
            Console.WriteLine("{0}", om);
            Console.ReadKey();
        }
    }
    class Sports : Marks {
        protected int om;
        string ab;
        public void acceptDetails()
        {
            Console.WriteLine("om + ab");
 //           base.acceptDetails();
            this.om = int.Parse(Console.ReadLine());
            this.ab = Console.ReadLine();
        }
        public void displayDetails()
        {
 //           base.displayDetails();
            Console.WriteLine("{0}-----{1}", om, ab);
            Console.ReadKey();
        }
    }
    class result : Sports {
        public void calResult() {
          
            if (this.om > 70) {
                Console.WriteLine("greater than 70");
            }
        }
    }
}
