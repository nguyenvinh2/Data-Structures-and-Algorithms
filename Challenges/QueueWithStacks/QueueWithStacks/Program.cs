using System;
using QueueWithStacks.Classes;
using StackAndQueue.Classes;
using Queue = QueueWithStacks.Classes.Queue;

namespace QueueWithStacks
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      QueueWithStacks();
      Console.ReadKey();
    }
    /// <summary>
    /// testing out new Queue
    /// </summary>
    static void QueueWithStacks()
    {
      Queue TestQueue = new Queue();
      TestQueue.Enqueue(new Node("Papa"));
      Console.WriteLine($"Made a Queue and its first value is {TestQueue.Peek().Data}");
      TestQueue.Enqueue(new Node("Can"));
      TestQueue.Enqueue(new Node("You"));
      TestQueue.Enqueue(new Node("Hear"));
      TestQueue.Enqueue(new Node("Me?"));
      Console.WriteLine($"Adding some more nodes with string \" Can You Hear Me \" and its first value should still be {TestQueue.Peek().Data}");
      TestQueue.Dequeue();
      Console.WriteLine($"Removing the front node and its value should be {TestQueue.Peek().Data}");
      TestQueue.Dequeue();
      Console.WriteLine($"Removing the front node and its value should be {TestQueue.Peek().Data}");
      TestQueue.Dequeue();
      Console.WriteLine($"Removing the front node and its value should be {TestQueue.Peek().Data}");
      TestQueue.Dequeue();
      Console.WriteLine($"Removing the front node and its value should be {TestQueue.Peek().Data}");
      TestQueue.Enqueue(new Node("Can"));
      TestQueue.Enqueue(new Node("You"));
      TestQueue.Enqueue(new Node("Hear"));
      TestQueue.Enqueue(new Node("Me?"));
      Console.WriteLine($"Adding some more nodes with string \" Can You Hear Me \" and its first value should still be {TestQueue.Peek().Data}");
      TestQueue.Dequeue();
      Console.WriteLine($"Removing the front node and its value should be {TestQueue.Peek().Data}");
    }
  }
}
