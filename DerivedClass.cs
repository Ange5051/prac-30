using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class DerivedClass : AClass
    {
        /// <summary>
        /// Переопеределеный виртуальный метод с именем Meethod2
        /// </summary>
        public override void Meethod2()
        {
            base.Meethod2();
            Console.WriteLine("Метод Meethod2 из класса AClass, реали-з в производ.кл. DerivedClass");
        }

        /// <summary>
        /// Переопеределеный абстрактный метод с именем Meethod3
        /// </summary>
        public override void Meethod3()
        {
            Console.WriteLine("Метод Meethod3 из класса AClass, реали-з в производ.кл.  DerivedClass");
        }
        /// <summary>
        /// Переопеределеный абстрактный метод с именем Meethod4
        /// </summary>
        public override void Meethod4()
        {
            Console.WriteLine("Метод Meethod4 из класса AClass, реали-з в производ.кл.  DerivedClass");
        }
    }
}
