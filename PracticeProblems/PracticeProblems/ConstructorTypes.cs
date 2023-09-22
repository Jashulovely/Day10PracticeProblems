using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ConstructorTypes
    {
        private string name;
        private int age;
        public ConstructorTypes()
        {
            name = "Jashu";
            age = 22;
            Console.WriteLine("name : " + name + " age : " + age);
            Console.WriteLine("Default and zero argument Constructor.");
        }
        public ConstructorTypes(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("name : " + name + " age : " + age);
            Console.WriteLine("Parameterised Constructor.");
        }
        static ConstructorTypes()
        {
        }
        private ConstructorTypes(string name)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("Private Constructor.");
        }
        public ConstructorTypes(ConstructorTypes ct)
        {
            name = ct.name;
            age = ct.age;
            Console.WriteLine("name : " + name + " age : " + age);
            Console.WriteLine("Copy Constructor.");
        }

        public static void Demo()
        {
            Console.WriteLine("Static Constructor.");
            Console.WriteLine("calling static method from static constructor.");
            ConstructorTypes ct = new ConstructorTypes("Amit");
        }
    }
}
