using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    interface IInterface
    {
        void Method();
    }

    abstract class AbstractClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method realisation in abstract class.");
        }
    }

    class ConcreteClass : AbstractClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            Console.ReadKey();
        }
    }
}
