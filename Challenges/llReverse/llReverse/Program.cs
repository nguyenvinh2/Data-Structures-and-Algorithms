using System;
using LinkedList;

namespace llReverse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      LinkList One = new LinkList();
      One.Append(new Node("Aaaah"));
      One.PrintAllNodes();
      Console.ReadKey();
    }
  }
}
