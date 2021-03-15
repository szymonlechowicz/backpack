using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class KnapsackTests
    {
        [TestMethod()]
        public void GreedyTest()
        {
            Knapsack kp = new Knapsack();
            Item[] items = new Item[5];
            items[0] = new Item(9, 10);
            items[1] = new Item(12, 7);
            items[2] = new Item(2, 1);
            items[3] = new Item(7, 3);
            items[4] = new Item(5, 2);
            bool[] knapsack = kp.Greedy(items, 5, 15);
            bool[] expectedResult = new bool[] {  true, false, true, false, false };
            bool result = knapsack.SequenceEqual(expectedResult);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GreedyTest2()
        {
            Knapsack kp = new Knapsack();
            Item[] items = new Item[1];
            items[0] = new Item(20, 5);
            bool[] knapsack = kp.Greedy(items, 1, 15);
            bool[] expectedResult = new bool[] { false };
            bool result = knapsack.SequenceEqual(expectedResult);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void GreedyTest3()
        {
            Knapsack kp = new Knapsack();
            Item[] items = new Item[5];
            items[0] = new Item(1, 10);
            items[1] = new Item(1, 10);
            items[2] = new Item(1, 10);
            items[3] = new Item(1, 10);
            items[4] = new Item(1, 10);
            bool[] knapsack = kp.Greedy(items, 5, 5);
            bool[] expectedResult = new bool[] { true, true, true, true, true };
            bool result = knapsack.SequenceEqual(expectedResult);
            Assert.IsTrue(result);
        }
        
        [TestMethod()]
        public void GreedyTest4() {
            Knapsack kp = new Knapsack();
            Item[] items = new Item[6];
            items[0] = new Item(1, 10);
            items[1] = new Item(1, 10);
            items[2] = new Item(1, 10);
            items[3] = new Item(1, 10);
            items[4] = new Item(1, 10);
            items[5] = new Item(1, 10);
            bool[] knapsack = kp.Greedy(items, 6, 5);
            bool[] expectedResult = new bool[] { true, true, true, true, true, false };
            bool result = knapsack.SequenceEqual(expectedResult);
            Assert.IsTrue(result);
        }



    }
}