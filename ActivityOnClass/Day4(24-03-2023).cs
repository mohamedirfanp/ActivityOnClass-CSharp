using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.ActivityOnClass
{
    internal class Program
    {

        public static void Mains(string[] args)
        {
            // Day-4 (24-03-2023)
            // Collection Class
            Collection();

        }

        public static void Collection()
        {

            // LinkedList
            //LinkedListClass();

            // Key Value Pair
            //DictionaryClass();

            // Sorted Dictionary
            SortedDictionaryClass();

        }
        public static void LinkedListClass()
        {

            // LinkedList Creation
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(2);
            linkedlist.AddLast(6);
            linkedlist.AddLast(2);

            // Single Node Creation 
            LinkedListNode<int> node = new LinkedListNode<int>(10);

            //linkedlist.AddAfter(node, 10);

            for(LinkedListNode<int> i= linkedlist.First; i!=null; i=i.Next)
            {
                if(i.Value == 2)
                    linkedlist.AddBefore(i,10);
            }

            foreach(var i in linkedlist) 
            {
                Console.WriteLine(i + " ");
            }
        }

        public static void DictionaryClass()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "Four");

            // To check a key present in the dictionary
            Console.WriteLine(dict.ContainsKey(3));

            // TO remove a keyvalue pair
            dict.Remove(3);

            // access the dict like array
            Console.WriteLine(dict[4]);
                
            foreach (KeyValuePair<int,string> kv in dict)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

        }

        public static void SortedDictionaryClass()
        {
            SortedDictionary<string, string> s_dict = new SortedDictionary<string, string>();

            s_dict.Add("A", "Apple");
            s_dict.Add("C", "Cat");
            s_dict.Add("B", "Ball");

            foreach(var  kv in s_dict)  
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }

            /*foreach(var item in s_dict.OrderBy(x => x.Value))
            {
              // the value of the dict is iterated

            }*/
        }

    }
}
