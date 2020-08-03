using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace MarksLibrary
{
    public class Marks : Student
    {
        int marks;
        public void acceptDetails()
        {
            base.acceptDetails();
            Console.WriteLine("observed marks");
         
            this.marks = int.Parse(Console.ReadLine());
        }
        public void displayDetails()
        {
         base.displayDetails();
            Console.WriteLine("{0}", marks);
            Console.ReadKey();
        }
    }
}
