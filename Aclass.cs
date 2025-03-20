using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AClass
    {
        /// <summary>
        /// обычный метод
        /// </summary>
        public void Meethod1()
        {
            Console.WriteLine("Обычный метод Meethod1 из а.к. AClass");
        }
        /// <summary>
        /// виртуальный метод
        /// </summary>
            public virtual void Meethod2() 
        {
            Console.WriteLine("Вирт.метод Meethod2 из а.к. AClass");
        }
        /// <summary>
        /// 
        /// </summary>
        public abstract void Meethod3();
        /// <summary>
        /// 
        /// </summary>
        public abstract void Meethod4();
    }
}
