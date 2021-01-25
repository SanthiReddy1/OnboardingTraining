using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    public class Polymorphism
    {
        public void MethodOverloading1()
        {
            Console.WriteLine("MethodOverloading1 method with no parameters");
        }
        public void MethodOverloading1(int parameter1)
        {
            Console.WriteLine("MethodOverloading1 method with one parameter:" + parameter1);
        }
        public void MethodOverriding()
        {
            Console.WriteLine("MethodOverriding method in Base Class");
        }
    }
    public class PolymorphismImplementation: Polymorphism
    {
        public new void MethodOverriding()
        {
            Console.WriteLine("MethodOverriding method in Derived Class");
        }
    }
}
