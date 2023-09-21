using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class DerivedClass : AbstractClass
    {
        public override void Do()
        {
            Console.WriteLine("Abstract Method.");
        }
    }
}
