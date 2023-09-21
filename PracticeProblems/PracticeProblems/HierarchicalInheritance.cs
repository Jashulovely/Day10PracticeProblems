using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class HierarchicalInheritance
    {
        public void Msg()
        {
            Console.WriteLine("Hierarchichal Inheritance");
        }
    }
    class A : HierarchicalInheritance
    {
        public void Info()
        {
            Msg();
            Console.WriteLine("this is child A class Method");
        }
    }
    class B : HierarchicalInheritance
    {
        public void GetInfo()
        {
            Msg();
            Console.WriteLine("this is child B class Method");
        }
    }
}
