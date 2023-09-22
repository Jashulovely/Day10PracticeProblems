using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class AccessModifiers
    {
        public void PublicAM()
        {
            Console.WriteLine("Public Access Modifier.");
            PrivateAM();
        }
        private void PrivateAM()
        {
            Console.WriteLine("Private Access Modifier.");
        }
        protected void ProtectedAM()
        {
            Console.WriteLine("Protected Access Modifier.");
        }
        internal void InternalAM()
        {
            Console.WriteLine("Internal Access Modifier.");
        }
    }
}
