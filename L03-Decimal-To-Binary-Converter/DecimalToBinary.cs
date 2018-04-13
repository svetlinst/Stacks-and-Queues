using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Decimal_To_Binary_Converter
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Stack<string> myStack = new Stack<string>();
            if (input ==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (input > 0)
                {
                    myStack.Push((input % 2).ToString());
                    input = input / 2;
                }

                while (myStack.Count>0)
                {
                    Console.Write(myStack.Pop());
                }
            }
            
        }
    }
}
