using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
       
        [Conditional("DEBUG")]
        private static void DebugOnlyMethod()
        {
            Console.WriteLine("This method is only included in DEBUG builds.");
        }

        
        static void Main2(string[] args)
        {
            Console.WriteLine("Starting application...");
            DebugOnlyMethod();
            Console.WriteLine("Application finished.");
        }
    }
}
