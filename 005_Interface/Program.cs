using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Interface
{
    interface IInterface1
    {
        void Method1();
    }

    interface IInterface2 : IInterface1
    {
        void Method2();
    }

    class ConcreteClass : IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method from Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Method from Interface2");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method1();
            instance.Method2();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method1();

            IInterface2 instanc2 = instance as IInterface2;
            instanc2.Method1();
            instanc2.Method2();


            Console.ReadKey();

        }
    }
}
