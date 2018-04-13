using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Simple_Text_Editor
{
    class SimpleEditor
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> commandStack = new Stack<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine();
                if (input[0] == '4')
                {
                    text.Clear();
                    text.Append(commandStack.Pop());
                }
                else
                {
                    var tokens = input.Split(' ').ToArray();
                    var command = int.Parse(tokens[0]);

                    switch (command)
                    {
                        case 1:
                            commandStack.Push(text.ToString());
                            text.Append(tokens[1]);
                            break;
                        case 3:
                            var printChar = text[int.Parse(tokens[1]) - 1];
                            Console.WriteLine(printChar);
                            break;
                        case 2:
                            commandStack.Push(text.ToString());
                            var charsToDel = int.Parse(tokens[1]);
                            text.Remove(text.Length - charsToDel, charsToDel);
                            break;
                    }
                }
            }
        }
    }
}
