﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool interested = true;
            while (interested)
            {
                Console.WriteLine("Enter your choice.\n   1   -->   Class and Object.\n   2   -->   Inheritance.\n" +
                    "   3   -->   Polymorphism.\n   0   -->   QUIT");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Test test = new Test();
                        test.Sample();
                        Console.ReadLine();
                        break;
                    case 2:
                        ChildClass childClass = new ChildClass();
                        childClass.ShowName();
                        childClass.DisplayAge();
                        childClass.Greet();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter your name.");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your age.");
                        int age = int.Parse(Console.ReadLine());    
                        Polymorphism polymorphism = new Polymorphism();
                        BaseClass baseClass = new BaseClass();
                        polymorphism.Display();
                        polymorphism.Display(name);
                        polymorphism.Display(name, age); 
                        baseClass.Marry();
                        polymorphism.Marry();
                        Console.ReadLine();
                        break;
                    case 0:
                        interested = false;
                        Console.WriteLine("Thanks for your interest.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
