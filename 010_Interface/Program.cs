using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interface
{
    interface IInterface
    {
        void Method();
    }

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }

    class DerivedClass: BaseClass, IInterface
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            IInterface instance1 = instance as IInterface;
            instance1.Method();

            Console.ReadKey();
        }
    }
}
