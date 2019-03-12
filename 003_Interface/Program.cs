using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();


            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            Console.ReadKey();
        }
    }
}
