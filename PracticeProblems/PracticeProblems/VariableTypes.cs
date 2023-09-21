using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class VariableTypes
    {
        // instance variable
        int a = 80;

        // static variable
        static int b = 40;

        // Constant variables
        const double PI = 3.14;

        // readonly variables
        readonly int k = 10;

        public void Display()
        {
            // local variable 
            int c = 100;
            Console.WriteLine("Instance Variable value : " + this.a);
            Console.WriteLine("Static Variable value : " + VariableTypes.b);
            Console.WriteLine("Constant Variable value : " + VariableTypes.PI);
            Console.WriteLine("Read Only Variable value : " + this.k);
            Console.WriteLine("Local Variable value : " + c);
        }
    }
}
