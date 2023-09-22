using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class ChildAM : AccessModifiers
    {
        public void ChildMethod()
        {
            Console.WriteLine("Child Class Method");
            ProtectedAM();
        }
        
    }
}
