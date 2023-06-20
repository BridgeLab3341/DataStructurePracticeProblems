namespace DataStructurePracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Display();
            //Stack<int>stacks= new Stack<int>();
            //stacks.Push(1);
            //stacks.Push(2);
            //stacks.Push(3);
            //stacks.Display();
           // stacks.Pop();
           Queues<int>queues = new Queues<int>();
            queues.Enqueue(1);
            queues.Enqueue(2);
            queues.Enqueue(3);
            queues.Display();
            queues.Dequeue();
            queues.Display();
        }
    }
}
