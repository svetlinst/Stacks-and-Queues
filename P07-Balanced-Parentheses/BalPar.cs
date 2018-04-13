using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Balanced_Parentheses
{
    class BalPar
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> parenthesisStack = new Stack<char>();
            var isBalanced = true;
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (currentChar == '(' || currentChar =='{' || currentChar =='[')
                {
                    parenthesisStack.Push(currentChar);
                }
                else if (input[0]!=')' && input[0] != ']' && input[0] != '}' && parenthesisStack.Count>0)
                {
                    switch (currentChar)
                    {
                        case ')':
                            if (parenthesisStack.Pop() != '(')
                            {
                                isBalanced = false;
                            }
                            break;
                        case ']':
                            if (parenthesisStack.Pop() != '[')
                            {
                                isBalanced = false;
                            }
                            break;
                        case '}':
                            if (parenthesisStack.Pop() != '{')
                            {
                                isBalanced = false;
                            }
                            break;
                    }
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
