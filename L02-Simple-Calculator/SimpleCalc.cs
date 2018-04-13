using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L02_Simple_Calculator
{
    class SimpleCalc
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Reverse();
            Stack<string> myStack = new Stack<string>(input.ToArray());
            while (myStack.Count>1)
            {
                var first = int.Parse(myStack.Pop());
                string op = myStack.Pop();
                var second = int.Parse(myStack.Pop());
                switch (op)
                {
                    case "+":
                        myStack.Push((first+second).ToString());
                        break;
                    case "-":
                        myStack.Push((first-second).ToString());
                        break;
                }
            }

            var result = myStack.Pop();
            Console.WriteLine(result);
        }
    }
}
