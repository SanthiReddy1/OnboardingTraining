using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Collections
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            Collections list = new Collections();
            list.ListCollection();
            //list.StackCollection();
            //list.DictionaryCollection();
            //list.QueueCollection();
            //list.ArrayListCollection();
            //list.SortedListCollection();
            //list.HashTableCollection();
        }
        public void PrintDuplicateValuesInArray()
        {
            int[] a = new int[] { 1, 5, 1, 4, 9, 5 };
            int[] b = a.Distinct().Where(x => x % 2 != 0).ToArray();
            int[] c = a.Where((x, y) => x.Equals(y)).ToArray();
            for (int i = 0; i < c.Length; i++) 
            {
                Console.WriteLine("Element of list at index " + i + ":" + c[i]);
            }
            int[] a1 = new int[] { 12, 13, 1, 3, 12, 13, 1, 3, 4, 4, 5 };
            List<int> l = a1.Where(x => x % 2 != 0).GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).ToList();
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine("Element of list at index " + i + ":" + l[i]);
            }
        }
        public void ListCollection()
        {
            List<String> Fruits = new List<String>();
            Fruits.Add("Apple");
            Fruits.Add("Grape");
            Fruits.Add("Banana");
            Fruits.Add("Orange");
            Fruits.Sort();
            Fruits.Reverse();
            for (int i = 0; i < Fruits.Count; i++)
            {
                Console.WriteLine("Element of list at index " + i + ":" + Fruits[i]);
            }

            Fruits.RemoveAt(2);
            Console.WriteLine("After removing element at index 2 ");
            for (int i = 0; i < Fruits.Count; i++)
            {
                Console.WriteLine(Fruits[i]);
            }

            Fruits.Add("PineApple");
            Fruits.Add("Mango");
            Fruits.Add("Papayya");

            Console.WriteLine("List of elements whose lenght>5");
            IEnumerable<String> LengthSort = Fruits.Where(x => x.Length > 5);
            foreach (String s in LengthSort)
            {
                Console.WriteLine(s);
            }

            IEnumerable<IGrouping<int, String>> grouping = Fruits.OrderBy(x => x).GroupBy(x => x.Length);
            foreach (IGrouping<int, String> s in grouping)
            {
                Console.WriteLine(s.Key);
                foreach (String value in s)
                {
                    Console.WriteLine(value);
                }
            }
        }
        public void StackCollection()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(1);
            stack.Push(8);
            stack.Push(6);
            stack.Push(9);
            stack.Push(5);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            int popedElement = stack.Pop();
            int PeekElement = stack.Peek();
            int max = stack.Max();
            int min = stack.Min();
            double avg = stack.Average();
            Console.WriteLine("ElementPoped" + popedElement);
            Console.WriteLine("Peek Element" + PeekElement);
            Console.WriteLine("Max" + max);
            Console.WriteLine("Min" + min);
            Console.WriteLine("Average" + avg);

            int[] arr = new int[] { 12, 13, 5, 3, 7, 9};
            Stack<int> stack1 = new Stack<int>(arr);
            IEnumerable<int> ConcatenatedStack = stack.Concat(stack1);
            Console.WriteLine("After Concatenation of two sequences");
            foreach (int i in ConcatenatedStack)
                Console.WriteLine(i);
        }

        public void QueueCollection()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Zebra");
            queue.Enqueue("Kite");
            queue.Enqueue("Ant");
            queue.Enqueue("Balloon");
            queue.Enqueue("Lion");
            queue.Enqueue("Hippo");
            queue.Enqueue("JellyFish");

            foreach(string s in queue)
            {
                Console.WriteLine(s);
            }
            string DequeuedElement = queue.Dequeue();
            Console.WriteLine("Element Dequeued is:"+DequeuedElement);
            IOrderedEnumerable<String> orderedQueue = queue.OrderBy(x=>x.Length);
            Console.WriteLine("After ordering the queue by ascending order");
            foreach (string s in orderedQueue)
            {
                Console.WriteLine(s);
            }           
        }

        public void DictionaryCollection()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1", "Black");
            dict.Add("7", "Blue");
            dict.Add("", "White");
            dict.Add("5", "");
            dict.Add("3", "Purple");
            dict.Add("6", "Black");
            foreach (var s in dict)
            {
                Console.WriteLine(s.Key +"_" + s.Value);
            }

            IEnumerable<IGrouping<string, KeyValuePair<string, string>>> orderedDictionary = dict.GroupBy(x=>x.Value);
            foreach(IGrouping<string, KeyValuePair<string, string>> d in orderedDictionary)
            {
                Console.WriteLine(d.Key);
                foreach(KeyValuePair<string,string> d1 in d)
                {
                    Console.WriteLine(d1.Key + "_" + d1.Value);
                }
            }
        }

        public void ArrayListCollection()
        {
            ArrayList arrayList = new ArrayList() { "Santhi", 24, "Software Test Automation Engineer","", "Guntur"};
            int count = arrayList.Count;
            Console.WriteLine("No.of elements in ArrayList:" + count);
            for (int i=0; i<count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }                
        }
        public void SortedListCollection()
        {
            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            foreach (KeyValuePair<string, string> kvp in cities)
            {
                Console.WriteLine(kvp.Key + "_" + kvp.Value);
            }
            Console.WriteLine("Contains New York key: " + cities.ContainsKey("New York"));
        }

        public void HashTableCollection()
        {
            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add(10, "ten");
            my_hashtable.Add("A3", "GeeksforGeeks");
            my_hashtable.Add(8, "Geeks!!");

            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }
        }
    }
}
