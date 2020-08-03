using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exception7
{
    class Student
    {
        public int StudentId;
        public string StudentName;
    }

    [Serializable]
    class InvalidStudentNameException : Exception {
        public InvalidStudentNameException(String name)
        : base(String.Format("Invalid Student Name:{0} ", name)) {
            Console.WriteLine("How you can resolve me??");
        }
    }

    class Program
    {
        static void validateStudent(Student s) {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(s.StudentName)) {
                throw new InvalidStudentNameException(s.StudentName);
            }
        }

        static void Main(string[] args)
        {
            Student obj = null;
            try {
                obj = new Student();
                obj.StudentName = "King123";
                validateStudent(obj);
            }
            catch (InvalidStudentNameException ex) {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
