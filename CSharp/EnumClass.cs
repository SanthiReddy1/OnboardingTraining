using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class EnumClass
    {
        public enum Fruits
        {
            Apples,
            Mangoes,
            Oranges,
            Papayya,
            Pineapple,
            Kiwi
        }

        public void ReadEnum()
        {
            Console.WriteLine(Fruits.Apples + " at index " + (int)Fruits.Apples);
            Console.WriteLine(Fruits.Kiwi + " at index " + (int)Fruits.Kiwi);
            Console.WriteLine(Fruits.Oranges + " at index " + (int)Fruits.Oranges);
        }
    }
}
