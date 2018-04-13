using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Reverse_Numbers_With_Stack
{
    class RevNum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            Stack<string> numbStack = new Stack<string>(numbers);
            while (numbStack.Count>0)
            {
                Console.Write(numbStack.Pop()+" ");
            }
        }
    }
}
