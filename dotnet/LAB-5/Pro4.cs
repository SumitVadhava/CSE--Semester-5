using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Pro4
    {
        public void queueOperations()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("Queue elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dequeue element: " + queue.Dequeue());
            
            Console.WriteLine("First Element of the "+queue.Peek());
            if(queue.Contains(3))
            {
                Console.WriteLine("Queue contains 3");
            }
            else
            {
                Console.WriteLine("Queue does not contain 3");
            }
            queue.Clear();

        }
    }
}
