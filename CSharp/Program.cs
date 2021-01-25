using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringOperations program = new StringOperations();
            program.OperationsOnStrings();
            HandlingExceptions handlingExceptions = new HandlingExceptions();
            handlingExceptions.HandleExceptions();
            EnumClass enumClass = new EnumClass();
            enumClass.ReadEnum();
            BreakContinue breakContinue = new BreakContinue();
            breakContinue.BreakMethod();
        }                
    }

}


       






