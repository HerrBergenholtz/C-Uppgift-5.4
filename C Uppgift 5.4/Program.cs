using System;
using System.Collections.Immutable;

namespace Uppgift_5._3
{
    class Program
    {
        public static void Main()
        {
            string[] namn = { "Ludwig", "Johan", "Zacharias", "Kevin", "Ameen" };

            int index = 0;

            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i].CompareTo(namn[index]) < 0)
                {
                    index = i;
                }
            }
            Console.WriteLine($"Namnet som kommer först i bokstavsordning är: {namn[index]}");
            Console.ReadKey();
        }
    }
}