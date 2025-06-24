using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Pro6
    {
        public void HashTableOperations()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Sumit");
            ht.Add(2, "Meet");
            ht.Add(3, "Harshil");
            ht.Add(4, "Manav");
            ht.Add(5, "Jasmin");
            
            Console.WriteLine("Hashtable elements:");
            
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            ht.Remove(5);
            Console.WriteLine("\n");
            Console.WriteLine("Hashtable elements after removing key 5:");
            
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }


            Console.WriteLine("\n");

            if (ht.ContainsKey(1))
            {
                Console.WriteLine("HashTable contains key 1 with value: " + ht[1]);
            }
            else
            {
                Console.WriteLine("HashTable does not contain key 1");
            }

            Console.WriteLine("\n");

            if (ht.ContainsValue("Sumit"))
            {
                Console.WriteLine("HashTable contains value 'Sumit'");
            }
            else
            {
                Console.WriteLine("HashTable does not contain value 'Sumit'");
            }

            ht.Clear();

        }
    }
}
