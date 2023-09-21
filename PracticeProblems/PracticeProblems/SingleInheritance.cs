using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class SingleInheritance
    {
        public void Credit()
        {
            Console.WriteLine("balance is credited");
        }
    }
    public class ChildSI:SingleInheritance
    {
        public void Debit()
        {
            Credit();                      
            Console.WriteLine("balance is debited");
            Console.WriteLine("Single Inheritance.");
        }
    }
}
