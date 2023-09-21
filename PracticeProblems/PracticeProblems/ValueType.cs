using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ValueType
    {
        public void GetValue()
        {
            int x = 100;
            int y = x;
            Console.WriteLine($"x = {x} y = {y}");
            y++;
            Console.WriteLine($"x = {x} y = {y}");
        }
    }
}

