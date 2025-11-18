using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program2
    {
        [Obsolete("Use NewMethod instead",false)]
        private static void OldMethod()
        {
            Console.WriteLine("This is the old method.");
        }
        private static void NewMethod()
        {
            Console.WriteLine("This is the new method.");
        }
        static void Main3(string[] args)
        {
            Console.WriteLine("Starting Program2 application...");
            OldMethod(); 
            NewMethod();
            Console.WriteLine("Program2 application finished.");
        }
    }
}
