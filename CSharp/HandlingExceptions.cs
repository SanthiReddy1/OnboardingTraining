using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class HandlingExceptions
    {
        public void HandleExceptions()
        { 
            try
            {
                Console.WriteLine("try block");
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block");
            }
            finally
            {
                Console.WriteLine("After try/catch finally() block gets executed");
            }
        }
    }
}
