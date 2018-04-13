using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Calculate_Sequence_With_Queue
{
    class SeqQueue
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Queue<long> sequence = new Queue<long>();
            List<long> result = new List<long>();
            sequence.Enqueue(n);
            result.Add(n);
            while (result.Count<50)
            {
                var curNumber = sequence.Dequeue();
                var secondNumber = curNumber + 1;
                var thirdNumber = 2 * curNumber + 1;
                var fourthNumber = curNumber + 2;

                //result.Add(curNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
                result.Add(fourthNumber);

                sequence.Enqueue(secondNumber);
                sequence.Enqueue(thirdNumber);
                sequence.Enqueue(fourthNumber);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
