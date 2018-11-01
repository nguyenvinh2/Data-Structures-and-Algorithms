using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Queue qer = new Queue(new Node("de"));
      qer.Dequeue();
      qer.Enqueue(new Node("dg"));
      Console.WriteLine(qer.Front.Data);

      Console.ReadKey();
   
    }
  }
}
