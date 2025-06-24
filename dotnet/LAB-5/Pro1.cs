using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
  
       
    
    internal class Pro1
    {

        public void ListOprations()
        {
            ArrayList studentName = new ArrayList();
            studentName.Add("Sumit");
            studentName.Add("Meet");
            studentName.Add("Harshil");
            studentName.Remove("Harshil");
            studentName.Add("Manav");
            studentName.RemoveRange(studentName.Count - 2, 2);  
            studentName.Add( "Meet");

            foreach (string name in studentName)
           {
                Console.WriteLine(name);
           }
            studentName.Clear();
        }

    }
}
