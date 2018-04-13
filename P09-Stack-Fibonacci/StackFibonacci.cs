using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Stack_Fibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            Stack<long> fiboStack = new Stack<long>();
            fiboStack.Push(0);
            fiboStack.Push(1);
            fiboStack.Push(2);
            for (int i = 3; i < number; i++)
            {
                var prevNumber = fiboStack.Pop();
                var nextNumber = fiboStack.Peek() + prevNumber;
                fiboStack.Push(prevNumber);
                fiboStack.Push(nextNumber);
            }

            if (number ==1)
            {
                Console.WriteLine($"1");
            }else if (number == 2)
            {
                Console.WriteLine($"1");
            }
            else
            {
                Console.WriteLine(fiboStack.Pop());
            }

        }
    }
}
