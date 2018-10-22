using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Stack stacky = new Stack(new Node("de"));
      stacky.Push(null);
      Console.ReadKey();
   
    }
  }
}
