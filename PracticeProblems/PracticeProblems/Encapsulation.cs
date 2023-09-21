using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Encapsulation
    {
        private String studentName;
        private int studentAge;
        public String Name
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return studentAge; }
            set { studentAge = value; }
        }
        public void Display()
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age.");
            int age = int.Parse(Console.ReadLine());
            this.Name = name;
            this.Age = age;
            Console.WriteLine(" Name : " + this.Name);
            Console.WriteLine(" Age : " + this.Age);
        }
    }
}
