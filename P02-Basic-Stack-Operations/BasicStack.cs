using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Basic_Stack_Operations
{
    class BasicStack
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').ToArray();
            var toPush = int.Parse(tokens[0]);
            var toPop = int.Parse(tokens[1]);
            var toCheck = int.Parse(tokens[2]);
            var allNumbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>();
            for (int i = 0; i < toPush; i++)
            {
                numbersStack.Push(allNumbersArr[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                numbersStack.Pop();
            }

            if (numbersStack.Contains(toCheck))
            {
                Console.WriteLine($"true");
            }
            else if (numbersStack.Count>0)
            {
                Console.WriteLine(numbersStack.Min());

            }
            else
            {
                Console.WriteLine($"0");
            }
        }
    }
}
