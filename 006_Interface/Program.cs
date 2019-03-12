using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Interface
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2 : IInterface1 
    {
        new void Method();
    }

    class ConcreteClass : IInterface2
    {
        void IInterface1.Method()
        {
            Console.WriteLine("Method from Interface1");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Method from Interface2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            Console.ReadKey();
        }
    }
}
