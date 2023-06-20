using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructurePracticeProblems
{
    internal class Stacks<T>
    {
        private Node<T> top;
        public Stacks()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is Pushed to Stack", value);
        }
        public void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
        public void Peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack Is Empty");
            }
            Console.WriteLine("{0} is in the top of the Stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is in the top of the Stack", this.top.data);
            this.top = this.top.Next;
        }
    }
}
