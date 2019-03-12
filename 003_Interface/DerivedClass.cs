using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interface
{
    class DerivedClass : Interface1, Interface2
    {
        void Interface1.Method()
        {
            Console.WriteLine("Method from Interface1");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Method from Interface2");
        }
    }
}
