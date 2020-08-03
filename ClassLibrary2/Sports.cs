using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarksLibrary;
using StudentLibrary;
namespace SportsLibrary
{
    public class Sports : Marks
    {
        protected int marks;
        string num;
        public void acceptDetails()
        {
            base.acceptDetails();
            Console.WriteLine("marks + num");
                  
            this.marks = int.Parse(Console.ReadLine());
            this.num = Console.ReadLine();
        }
        public void displayDetails()
        {
                   base.displayDetails();
            Console.WriteLine("{0}-----{1}", marks, num);
            Console.ReadKey();
        }
    }
}
