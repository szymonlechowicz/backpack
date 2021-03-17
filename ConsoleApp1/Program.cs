using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorCS;


namespace ConsoleApp1
{
    public class Item : IComparable<Item>
    {
        public int weight;
        public int value;
        public float valueToWeight;
        public Item(int obWeight, int obValue)
        {
            weight = obWeight;
            value = obValue;
            valueToWeight = value / (float)weight;
        }
        public int CompareTo(Item other)
        {
            return valueToWeight.CompareTo(other.valueToWeight);
        }

    }
    public class Knapsack
    {
        public bool[] Greedy(Item[] obj, int amount, int capacity)
        {
            int i, j;
            int actualWeight = 0;
            bool[] put = new bool[amount];

            for (i = 0; i < amount; i++)
            {
                put[i] = false;
            }

            Array.Sort(obj);
            Array.Reverse(obj);
            for (i = 0; i < amount; i++)
            {
                if (obj[i].weight + actualWeight <= capacity)
                {
                    put[i] = true;
                    actualWeight += obj[i].weight;
                }
            }
            return put;
        }
        static void Main(string[] args)
        {
            int i;
            RandomNumberGenerator rnd = new RandomNumberGenerator(1);

            //Console.Write("Number of items: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Knapsack capacity: ");
            //int c = int.Parse(Console.ReadLine());

            int n = rnd.nextInt(5, 29);
            int c = rnd.nextInt(15, 49);

            Console.WriteLine("Number: " + n + "\tCapacity: " + c);
            
            int[] v = new int[n]; // values
            int[] w = new int[n]; // weights
            bool[] knapsack = new bool[n]; // 0, 1
            Item[] objects = new Item[n];

            //for (i = 0; i < n; ++i)
            //{
            //     Console.WriteLine("Put value of item " + i + ":");
            //     int value = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Put weight of item " + i + ":");
            //     int weight = int.Parse(Console.ReadLine());
            //     objects[i] = new Item(weight, value);
            //}

            Console.WriteLine("\tvalues\tweight");

            for (i = 0; i < n; ++i)
            {
                int value = rnd.nextInt(1, 29);
                int weight = rnd.nextInt(1, 29);
                objects[i] = new Item(weight, value);
                Console.WriteLine("\t" + value + "\t" + weight);
            }

            var kp = new Knapsack();
            knapsack = kp.Greedy(objects, n, c);
            Console.Write("Items in knapsack:\n\tvalue\tweight\n");
            for (i = 0; i < n; i++)
            {
                if (knapsack[i] == true)
                {
                    Console.WriteLine("\t" + objects[i].value + "\t" + objects[i].weight);
                }
            }
            Console.ReadLine();
           
        }
    public static bool[] Generate(int n, int c, ref Item[] objects) {
      RandomNumberGenerator rnd = new RandomNumberGenerator(1);
      int[] v = new int[n]; // values
      int[] w = new int[n]; // weights
      bool[] knapsack = new bool[n]; // 0, 1
      objects = new Item[n];
      for(int i = 0; i < n; ++i) {
        int value = rnd.nextInt(1, 29);
        int weight = rnd.nextInt(1, 29);
        objects[i] = new Item(weight, value);
      }

      var kp = new Knapsack();
      knapsack = kp.Greedy(objects, n, c);
      return knapsack;
    }
  }
}
