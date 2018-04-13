using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Hot_Potato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            Queue<string> players = new Queue<string>(input);
            while (players.Count !=1)
            {
                for (int i = 1; i < number; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
