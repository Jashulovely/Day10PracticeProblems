using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class MultiLevelInheritance
    {
        public void Mammal()
        {
            Console.WriteLine("Multi Level Inheritance");
        }
    }
    public class Human : MultiLevelInheritance
    {
        public void HumanDet()
        {
            Mammal();
            Console.WriteLine("Human class");
        }
    }
    public class Predators : Human
    {
        public void PredatorsDet()
        {
            Mammal();
            HumanDet();
            Console.WriteLine("Predators class");
        }
    }
}
