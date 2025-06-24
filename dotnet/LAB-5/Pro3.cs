using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Pro3
    {
        public void StackOperations()
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(10);
            s1.Push(20);
            s1.Push(30);
            s1.Push(40);
            s1.Push(50);
            s1.Pop();
            s1.Pop();
            Console.WriteLine("Top element :"+s1.Peek());
            if(s1.Contains(20))
            {
                Console.WriteLine("Stack contains 20");
            }
            else
            {
                Console.WriteLine("Stack does not contain 20");
            }
            foreach (int item in s1)
            {
                Console.WriteLine(item);
            }
            s1.Clear();
        }
    }
}
