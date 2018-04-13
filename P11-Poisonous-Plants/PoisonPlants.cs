using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Poisonous_Plants
{
    class PoisonPlants
    {
        static void Main(string[] args)
        {
            var numberOfPlants = int.Parse(Console.ReadLine());
            var endNumber = 0;
            Queue<int> plants = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            var startNumber = plants.Count;
            while (startNumber!=endNumber)
            {
                startNumber = plants.Count;
                for (int i = 0; i < numberOfPlants; i++)
                {
                    var leftPlant = plants.Dequeue();
                    var rightPlant = plants.Dequeue();
                    if (leftPlant > rightPlant)
                    {
                        plants.Enqueue(leftPlant);
                        plants.Enqueue(rightPlant);
                    }
                    else
                    {
                        plants.Enqueue(leftPlant);
                    }
                }
                endNumber = plants.Count;
            }

            Console.WriteLine(endNumber);
        }
    }
}
