using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Reverse_strings
{
    class RevStr
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> myStack = new Stack<char>(input.ToCharArray());
            while (myStack.Count>0)
            {
                Console.Write(myStack.Pop().ToString());
            }
        }
    }
}
