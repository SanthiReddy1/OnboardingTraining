using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    public class Encapsulation
    {
        public int publicvariable;
        private int privatevariable;
        protected int protectedvariable = 7;
        internal int internalvariable = 10;
        public void SetPrivateVariable(int value)
        {
            privatevariable = value;
        }

        public int GetPrivateVariable()
        {
            return privatevariable;
        }
    }
    public class DerivedClass: Encapsulation
    {
        public void PrintProtectedVariable()
        {
            Console.WriteLine("Value of Protected Variable in Derived Class:" + protectedvariable);
        }

    }
        
}
