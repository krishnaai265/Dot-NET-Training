using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte, shot and char --> First converted into integer --> Than Calculated
            byte i = 100;
            byte j = 200;
            byte k = (byte)(i+j);//Data lose chances
            Console.WriteLine(k);
            int l = i + j;
            Console.WriteLine(l);

            int a = (int)(100 + 200.0F);//Type Casting(Only for calculation)
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
