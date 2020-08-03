using System;
using SportsLibrary;
using StudentLibrary;
using MarksLibrary;
using SportsLibrary;

namespace ResultsLibrary
{
    public class result : Sports
    {
        public void calResult()
        {

            if (this.marks > 70)
            {
                Console.WriteLine("greater than 70");
            }
        }
    }
}
