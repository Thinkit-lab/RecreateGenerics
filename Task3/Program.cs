// See https://aka.ms/new-console-template for more information
using System;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(new List<int>());
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());
            Console.WriteLine("Pop the last item: " + stack.Pop());
            Console.WriteLine("Peek the last item: " + stack.Peek());
            Console.WriteLine("Stack size is: " + stack.Size());

            Console.WriteLine("-------------------------------------");

            Queue<int> queue = new Queue<int>(new List<int>());
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Is queue empty? " + queue.IsEmpty());
            Console.WriteLine("Dequeue the first item: " + queue.Dequeue());
            Console.WriteLine("Queue size is: " + queue.Size());

            Console.WriteLine("-------------------------------------");

            LinkedList<int> linkedList = new LinkedList<int>(new List<int>());
            Console.WriteLine(linkedList.Add(1));
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Console.WriteLine("Remove first occurence of 1: " + linkedList.Remove(1));
            Console.WriteLine("Check for 1: " + linkedList.Check(1));
            Console.WriteLine("Index of 1 is: " + linkedList.Index(1));
        }
    }
    
}
