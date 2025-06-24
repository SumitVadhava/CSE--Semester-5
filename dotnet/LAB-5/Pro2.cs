using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Pro2
    {
        public void ListOperations()
        {
            List<string> studentNames = new List<string>();
            studentNames.Add("Sumit");
            studentNames.Add("Meet");
            studentNames.Add("Harshil");
            studentNames.Remove("Harshil");
            studentNames.Add("Manav");
            studentNames.Add("Jasmin");
            studentNames.RemoveRange(1, 3);
            studentNames.Add("Meet");

            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
            studentNames.Clear();
        }
    }
}
