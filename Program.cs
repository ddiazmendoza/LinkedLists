using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class SampleData 
    {
        public static List<int> SampleList = new List<int>() {5, 4, 8, 7, 9, 2, 4}; // 7
    }
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = LoadSampleData();

            linkedList.Insert(66, 2);
            linkedList.Print();

            linkedList = linkedList.Sort();
            linkedList.Print();
        }

        private static LinkedList LoadSampleData()
        {
            var linkedList = new LinkedList();
            foreach (var data in SampleData.SampleList)
            {
                linkedList.Append(data);
            }
            return linkedList;
        }
    }
}
