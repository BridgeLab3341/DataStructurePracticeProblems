using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePracticeProblems
{
    internal class InBuiltFunction
    {
     public void LinkedListInBuilt()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(30);
            list.AddFirst(40);
            list.AddLast(50);
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }
            list.Remove(30);
            Console.WriteLine("After removing elements from linked list");
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }
        }
    }
}
