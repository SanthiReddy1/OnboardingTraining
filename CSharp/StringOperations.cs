using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class StringOperations
    {
        public void OperationsOnStrings()
        {
            string FruitName = "Apple";
            string FruitType = "Fruit";
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append(FruitName);
            stringbuilder.Append(" is a ");
            stringbuilder.Append(FruitType);
            Console.WriteLine(stringbuilder);
            foreach (var s in FruitName)
            {
                Console.WriteLine(s);
            }
            bool b = FruitName.Equals("Appl");
            Console.WriteLine(FruitName + " matches with Appl: " + b);
            Console.WriteLine(FruitName.Replace("e", "es"));
            string fruit = "Apple is a delicios fruit";
            string[] splitstring = fruit.Split(' ');
            for(int i=0; i<splitstring.Length;i++)
            {
                Console.WriteLine(splitstring[i]);
            }

        }
    }
}
