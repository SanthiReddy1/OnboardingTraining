using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class BreakContinue
    {
        public void BreakMethod()
        {
            for(int i=0; i<100; i++)
            {
                if(i==11)
                {
                    Console.WriteLine("continues when i=" + i);
                    continue;
                }
                if(i==12)
                {
                    Console.WriteLine("breaks when i=" + i);
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
