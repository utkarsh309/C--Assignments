using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Attributes
{
    internal class Program3
    {
        [AttributeUsage(AttributeTargets.Method, Inherited = false)]
        public class AuthorAttribute : Attribute
        {
            public string DeveloperName { get; }
            public double Version { get; }

            public AuthorAttribute(string developerName, double version)
            {
                DeveloperName = developerName;
                Version = version;
            }
        }
        [Author("Utkarsh Raj", 1.0)]
        private static void SampleMethod()
        {
            Console.WriteLine("This method has a custom Author attribute.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Program3 application...");
            SampleMethod();
            Console.WriteLine("Program3 application finished.");
            Type t = typeof(Program3);

            var classAttr = (AuthorAttribute)Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));

            Console.WriteLine($"{classAttr.DeveloperName} - Version {classAttr.Version}");



           

        }
    }
}
