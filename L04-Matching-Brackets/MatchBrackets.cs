using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Matching_Brackets
{
    class MatchBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> myStack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    myStack.Push(i);
                }else if (input[i]==')')
                {
                    var startIndex = myStack.Pop();
                    var expression = input.Substring(startIndex, i- startIndex+1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
