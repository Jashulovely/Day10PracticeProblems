using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ReferenceType
    {
        public int a = 100;
        public void GetReference()
        {
            ReferenceType reference1 = new ReferenceType();
            ReferenceType reference2 = reference1;
            Console.WriteLine($"reference1.a = {reference1.a} reference2.a ={reference2.a}");
            reference2.a = 200;
            Console.WriteLine($"reference1.a = {reference1.a} reference2.a ={reference2.a}");
        }
    }
}
