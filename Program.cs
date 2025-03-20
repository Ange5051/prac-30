using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Meethod1();
            derivedClass.Meethod2();
            derivedClass.Meethod3();
            derivedClass.Meethod4();
            Console.ReadKey();
        }
    }
}
