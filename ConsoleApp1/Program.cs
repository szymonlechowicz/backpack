using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Object: IComparable<Object>
    {
        public int weight;
        public int value;
        public float valueToWeight;
        public Object(int obWeight, int obValue)
        {
            weight = obWeight;
            value = obValue;
            valueToWeight = value / (float)weight;
        }
        public int CompareTo(Object other)
        {
            return valueToWeight.CompareTo(other.valueToWeight);
        }

    }
    class Program
    {
        public static char[] Greedy(Object[] obj, int amount, int capacity)
        {
            int i, j;
            int actualWeight = 0;
            Object tmp;
            char[] put = new char[amount];

            for (i = 0; i < amount; i++)
            {
                put[i] = '0';
            }

      // sorting
      //for (i = 0; i < amount - 1; i++)
      //{
      //    for (j = 0; j < amount - 1; j++)
      //    {
      //        if (obj[j].valueToWeight < obj[j+1].valueToWeight)
      //        {
      //            tmp = obj[j];
      //            obj[j] = obj[j + 1];
      //            obj[j + 1] = tmp;

      //        }
      //    }
      //}
            Array.Sort(obj);
            Array.Reverse(obj);
            for (i = 0; i < amount; i++)
            {
                if (obj[i].weight + actualWeight <= capacity)
                {
                    put[i] = '1';
                    actualWeight += obj[i].weight;
                }
            }
            return put;
        }
        static void Main(string[] args)
        {
            int i;

            Console.Write("Amount of subjects: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Knapsack capacity: ");
            int c = int.Parse(Console.ReadLine());
            
            int[] v = new int[n]; // values
            int[] w = new int[n]; // weights
            char[] Knapsack = new char[n]; // 0, 1
            Object[] objects = new Object[n];
            for (i = 0; i < n; ++i)
            {
                 Console.WriteLine("Put value of object " + i + ":");
                 int value = int.Parse(Console.ReadLine());
                 Console.WriteLine("Put weight of object " + i + ":");
                 int weight = int.Parse(Console.ReadLine());
                 objects[i] = new Object(weight, value);
            }
            

            Knapsack = Greedy(objects, n, c);
            Console.WriteLine("Objects in knapsack: (value and weight) \n");
            for (i = 0; i < n; i++)
            {
                if (Knapsack[i] == '1')
                {
                    Console.WriteLine(objects[i].value + " " + objects[i].weight);
                }
            }
            Console.ReadLine();
           
        }
        
    }
}
