using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Maximum_Element
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            Stack<int> maxValues = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                switch (command[0])
                {
                    case 1:
                        sequence.Push(command[1]);
                        if (maxValues.Count == 0 || maxValues.Peek() < command[1])
                            maxValues.Push(command[1]);
                        break;
                    case 2:
                        if (sequence.Count > 0)
                        {
                            if (maxValues.Count == 0)
                                sequence.Pop();
                            else if (maxValues.Peek() == sequence.Pop())
                                maxValues.Pop();
                        }
                        break;
                    case 3:
                        if (sequence.Count > 0)
                            Console.WriteLine(maxValues.Peek());
                        break;
                }
            }
        }
    }
}
