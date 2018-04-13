using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Truck_Tour
{
    class TrTour
    {
        static void Main(string[] args)
        {
            var iterations = int.Parse(Console.ReadLine());
            var fuelInfo = new int[iterations];
            var distanceInfo = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
                var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var petrolAmount = tokens[0];
                var distanceBetweenPumps = tokens[1];
                fuelInfo[i] = petrolAmount;
                distanceInfo[i] = distanceBetweenPumps;
            }
            Queue<int> remainingFuel = new Queue<int>();
            var fuelLeftover = 0;
            var intialStation = 0;
            while (true)
            {
                var isSuccessfull = false;

                for (int i = 0; i <iterations ; i++)
                {
                    isSuccessfull = true;
                    remainingFuel.Enqueue(fuelInfo[(intialStation+i)%iterations] + fuelLeftover);
                    if (distanceInfo[(intialStation + i) % iterations] <= remainingFuel.Peek())
                    {
                        fuelLeftover = remainingFuel.Dequeue()- distanceInfo[(intialStation + i) % iterations];
                    }
                    else
                    {
                        isSuccessfull = false;
                        fuelLeftover = 0;
                        remainingFuel.Clear();
                        break;
                    }
                }

                if (isSuccessfull)
                {
                    Console.WriteLine($"{intialStation}");
                    break;
                }
                intialStation++;
            }
           
        }
    }
}
