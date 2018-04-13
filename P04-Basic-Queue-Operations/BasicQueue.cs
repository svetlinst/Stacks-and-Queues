using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Basic_Queue_Operations
{
    class BasicQueue
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var toEnqueue = tokens[0];
            var toDequeue = tokens[1];
            var toCheck = tokens[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbQueue = new Queue<int>();
            for (int i = 0; i < toEnqueue; i++)
            {
                numbQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < toDequeue; i++)
            {
                if (numbQueue.Count>0)
                {
                    numbQueue.Dequeue();
                }
            }

            if (numbQueue.Contains(toCheck))
            {
                Console.WriteLine($"true");
            }else if (numbQueue.Count ==0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                Console.WriteLine($"{numbQueue.Min()}");
            }

        }
    }
}
