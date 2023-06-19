using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePracticeProblems
{
    internal class LinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into the LinkedList", node.data);
        }
        public void AddReverse(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.Next = temp;
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.Next;
            }
        }
        public void InsertBetwen(int position, T data)
        {
            Node<T> newestnode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newestnode;
            }
            if (position == 0)
            {
                newestnode.Next = this.head;
                this.head = newestnode;
                return;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.Next;
                count++;
            }
            newestnode.Next = prev.Next;
            prev.Next = newestnode;
        }
        public void DeleteFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            this.head = this.head.Next;
        }
        public void DeleteLastElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Node<T> node2 = head;
            if (head.Next == null)
            {
                this.head = null;
            }
            while (node2.Next.Next != null)
            {
                node2 = node2.Next;
            }
            node2.Next = null;
        }
        public int SearchNode(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine(count);
                }
                node = node.Next;
                count++;
            }
            return count;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.Next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }
            if (temp == null || temp.Next == null)
            {
                return;
            }
            Node<T> next = temp.Next.Next;
            temp.Next = next;
            Size();
        }
        public void Size()
        {
            int count = 0;
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("Size is " + count);
        }
    }
}
