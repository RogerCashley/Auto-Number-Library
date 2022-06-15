using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetFramework.Library;

namespace Auto_Number_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString1 = "INV/001";
            string testString2 = "INV/001A";
            string testString3 = "INV/999A";

            Console.WriteLine(testString1.Add(1)); // INV/002
            Console.WriteLine(testString2.Add(1)); // INV/002A
            Console.WriteLine(testString3.Add(1)); // INV/1000A

            Console.ReadKey();
        }
    }
}
