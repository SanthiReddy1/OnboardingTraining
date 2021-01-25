using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            BoquetClass boquetClass = new BoquetClass();
            Console.WriteLine("Cost of a Boquet: " + boquetClass.CalculateBoquetCost());
        }
    }
}
