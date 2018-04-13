using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Traffic_Light
{
    class TrafficLight
    {
        static void Main(string[] args)
        {
            Queue<string> trafficQueue = new Queue<string>();
            int carsToPass = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();
            int counter = 0;
            while (line !="end")
            {
                if (line !="green")
                {
                    trafficQueue.Enqueue(line);
                }else if (line =="green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (trafficQueue.Count>0)
                        {
                            Console.WriteLine($"{trafficQueue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                line = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
