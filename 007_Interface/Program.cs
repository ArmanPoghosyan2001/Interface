using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Interface
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2
    {
        void Method();
    }

    class ConcreteClass : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("Method realisation Interface(1-2)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            Console.ReadKey();

        }
    }
}
