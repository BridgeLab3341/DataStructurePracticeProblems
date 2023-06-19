using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePracticeProblems
{
    internal class Node<T>
    {
        public Node<T> Next;
        public T data;
        public Node(T data)
        {
            this.data = data;
            Next = null;
        }
    }
}
