using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class ListTest
    {
        public void Test()
        {
            List<int> listOfInts = new List<int>();

            Console.WriteLine("Ilość elementów w kolekcji int'ów: " + listOfInts.Count);

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                listOfInts.Add(random.Next(0, 21));
            }

            Console.WriteLine("Lista wylosowanych int'ów");
            for (int i = 0; i < listOfInts.Count; i++)
            {
                Console.Write(listOfInts[i] + ", ");
            }
            Console.WriteLine();

            List<double> listOfDoubles = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                listOfDoubles.Add(Math.Round(random.NextDouble() * 20, 2));
            }

            Console.WriteLine("Lista wylosowanych double'ów");
            foreach (var item in listOfDoubles)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Max w int'ach: " + MaxFromInts(listOfInts));
            Console.WriteLine("Max w double'ach: " + MaxFromDouble(listOfDoubles));

        }

        private int MaxFromInts(List<int> list)
        {
            int max = list[0];
            foreach (int item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        private double MaxFromDouble(List<double> list)
        {
            double max = list[0];
            foreach (double item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

    }
}
