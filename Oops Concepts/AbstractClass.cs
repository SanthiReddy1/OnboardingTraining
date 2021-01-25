using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    public abstract class AbstractClass
    {
        public abstract void Method1();
        public void Method2()
        {
            Console.WriteLine("Method2 in Abstract class");
        }
    }
    public class AbstractClassImplementation : AbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine("Abstract class Method1 implementation in AbstractClassImplementation");
        }
    }
}
