using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Dog says: bow bow");
        }
    }
}
