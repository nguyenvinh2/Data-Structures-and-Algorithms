using System;
using System.Collections.Generic;
using Tree.Classes;
using StackAndQueue.Classes;

namespace BreadthFirstTraversal
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(2);
      TreeRoot.Left = new Tree.Classes.Node(3);
      TreeRoot.Right = new Tree.Classes.Node(4);
      TreeRoot.Left.Left = new Tree.Classes.Node(5);
      TreeRoot.Left.Right = new Tree.Classes.Node(6);
      TreeRoot.Right.Left = new Tree.Classes.Node(7);
      TreeRoot.Right.Right = new Tree.Classes.Node(8);

      List<int> OutputList = BreadthFirst(TreeRoot);

      Console.WriteLine();
      foreach (var item in OutputList)
      {
        Console.Write($"{item} ");
      }

      Console.ReadKey();
    }

    public static List<int> BreadthFirst(Tree.Classes.Node Root)
    {
      List<int> Output = new List<int>();
      return BreadthFirst(Root, Output);
    }

    public static List<int> BreadthFirst(Tree.Classes.Node Root, List<int> Output)
    {
      Queue BreadthPrint = new Queue(new StackAndQueue.Classes.Node(Root));

      while (BreadthPrint.Front != null)
      {
        Tree.Classes.Node Current = (Tree.Classes.Node)BreadthPrint.Dequeue().Data;
        Console.Write($"{Current.Data} ");
        Output.Add(Current.Data);
        if (Current.Left != null)
        {
          BreadthPrint.Enqueue(new StackAndQueue.Classes.Node(Current.Left));
        }
        if (Current.Right != null)
        {
          BreadthPrint.Enqueue(new StackAndQueue.Classes.Node(Current.Right));
        }
      }
      return Output;
    }
  }
}
