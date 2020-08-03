using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleConnectiontoFirstBlankSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int Employeeid=1;
            string EmployeeName="Krishna Kumar Singh";
            float EmployeeSalary=1200;
            Console.WriteLine("Please enter Employeeid + EmployeeName + EmployeeSalary");
            Employeeid = int.Parse(Console.ReadLine());//Type Conversion

            EmployeeName = Console.ReadLine();
            EmployeeSalary = Convert.ToSingle(Console.ReadLine()); 

            Console.WriteLine(Employeeid+EmployeeName+EmployeeSalary);
            Console.WriteLine("{0}---{1}------{2}", Employeeid, EmployeeName, EmployeeSalary);
            Console.WriteLine("Hii! I am Krishna!");
            
            DateTime sysTime = DateTime.Now;
            DateTime setTime = DateTime.Parse("15:03:00");
            Console.WriteLine(sysTime.ToString("hh:mm:ss"));
            Console.WriteLine(setTime.TimeOfDay);
            int i = TimeSpan.Compare(setTime.TimeOfDay, sysTime.TimeOfDay);
            if(i==0){
                Console.WriteLine("True");
            }else{
            Console.WriteLine("False");
                }
                Console.ReadKey();
            
        }
    }
}
