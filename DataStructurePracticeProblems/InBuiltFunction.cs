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
        public void StacksInBuilt()
        {
            Stack<int> list = new Stack<int>();
            list.Push(30);
            list.Push(40);
            list.Push(80);
            foreach(int data in list)
            {
                Console.WriteLine(data);
            }
            list.Pop();
            Console.WriteLine("After removing elements from linked list ");
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }
        }
        public void InBuiltQueues()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(30);
            queue.Enqueue(60);
            queue.Enqueue(40);
            foreach(int data in queue)
            {
                Console.WriteLine(data);
            }
            queue.Dequeue();
            Console.WriteLine("After Removing Elements from linkedlist");
            foreach ( int data in queue)
            {
                Console.WriteLine(data);
            }
        }
    }
}
