using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading4
{
    class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public float add(float a, float b)
        {
            return a + b;
        }
        public int add(int[] arr1)
        {
            int result = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                result += arr1[i];
            }
            return result;
        }
        public double add(double[] arr1)
        {
            double result = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                result += arr1[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program o = new Program();
            int a = o.add(5, 6);
            Console.WriteLine(a);
            Console.WriteLine(o.add(5.0F, 6.4F));
            int[] arr = {1, 2, 3, 4 };
            double[] arr1 = { 1.2, 2.3, 4.6 };
            Console.WriteLine(o.add(arr));
            Console.WriteLine(o.add(arr1));
            Console.ReadKey();
        }
    }
}
