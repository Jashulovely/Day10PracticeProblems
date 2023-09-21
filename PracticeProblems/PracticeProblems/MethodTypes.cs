using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class MethodTypes
    {
        
        public virtual void Display()
        {
            Console.WriteLine("Virtual method.");
        }
        public void DoSomething()
        {
            this.DoSomethingElse();
        }
        public void DoSomethingElse()
        {
            Console.WriteLine("Instance method.");
        }
        public static void Show()
        {
            Console.WriteLine("Static Method.");
        }
    }
}
    


