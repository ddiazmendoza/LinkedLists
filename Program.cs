using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class SampleData 
    {
        public static List<int> SampleList = new List<int>() {1, 4, 5, 7, 9, 2, 4};
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList(); 

            foreach (var data in SampleData.SampleList)
            {
                linkedList.Append(data);
            }

            linkedList.Insert(2, 12);
            linkedList.Print();
        }
    }
}
