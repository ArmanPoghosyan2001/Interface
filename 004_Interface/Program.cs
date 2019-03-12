using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            instance.Method1();
            instance.Method2();

            Console.WriteLine(new string('-',50));

            BaseClass instance0 = instance as BaseClass;
            instance0.Method();

            Interface1 instance1 = instance as Interface1;
            instance1.Method1();

            Interface2 instance2 = instance as Interface2;
            instance2.Method2();

            Console.ReadKey();
        }
    }
}
