using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Pro5
    {
        public void dictionaryOperations()
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1, "Sumit");
            dict1.Add(2, "Meet"); 
            dict1.Add(3, "Harshil");
            dict1.Add(4, "Manav");
            dict1.Add(5, "Jasmin");

            Console.WriteLine("Dictionary elements:");

            foreach (var item in dict1)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            
            dict1.Remove(5);
            Console.WriteLine("\n");
            Console.WriteLine("Dictionary elements after remove key5:");
            

            foreach (var item in dict1)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            
            Console.WriteLine("\n");

            if (dict1.ContainsKey(1))
            {
                Console.WriteLine("Dictionary contains key 1 with value: " + dict1[1]);
            }
            else
            {
                Console.WriteLine("Dictionary does not contain key 1");
            }

            Console.WriteLine("\n");

            if (dict1.ContainsValue("Sumit"))
            {
                Console.WriteLine("Dictionary contains value 'Sumit'");
            }
            else
            {
                Console.WriteLine("Dictionary does not contain value 'Sumit'");
            }
            
            dict1.Clear();
        }
    }
}
