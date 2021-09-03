using System;
using System.Collections.Generic;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sampleList = new List<int>() { 1, 5, 10, 3, 6 };

            LinkedList linkedList = new LinkedList(); 

            foreach (var data in sampleList)
            {
                linkedList.Append(data);
            }

            linkedList.Insert(2, 1);
            
            linkedList.Print();


            
        }
    }
}
