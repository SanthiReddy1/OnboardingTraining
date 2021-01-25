using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    interface Interface1
    {
        void InterfaceMethod();
    }
    public class InterfaceImplementation: Interface1
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface Method Implementation");
        }
    }
}
