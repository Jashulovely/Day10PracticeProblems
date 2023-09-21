using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Polymorphism : BaseClass
    {
        public void Display()
        {
            Console.WriteLine("It is a regular method with no argument.");
            Console.WriteLine("Hello");
        }
        public void Display(string name)
        {
            Console.WriteLine("It is an overloaded method with one argument.");
            Console.WriteLine("Hello " + name);
        }
        public void Display(string name, int age)
        {
            Console.WriteLine("It is an overloaded method with two arguments.");
            Console.WriteLine("Hello " + name + ", your age is ; " + age);
        }

        public override void Marry()
        {
            Console.WriteLine("It is an overridden marry method.");
            Console.WriteLine("No, I don't marry SubbaLakshmi. I will marry Anushka Shetty.");
        }
    }
}
