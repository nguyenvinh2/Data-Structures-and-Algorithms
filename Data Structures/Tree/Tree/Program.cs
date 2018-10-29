using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      BinarySearchTree test = new BinarySearchTree();
      test.Add(5);
      test.Add(4);
      test.Add(3);
      Console.WriteLine($"Test one two three {test.Root.Left.Data}");

      Node find = test.Search(4);
      Console.WriteLine($"hey {find.Left.Data}");

      Node Root = new Node(2);
      Root.Left = new Node(3);
      Root.Right = new Node(4);

      Root.Left.Left = new Node(5);
      Root.Left.Right = new Node(6);
      Root.Right.Left = new Node(7);
      Root.Right.Right = new Node(8);

      BinaryTree yay = new BinaryTree();

      yay.PostOrder(Root);

      Console.WriteLine();

      yay.InOrder(Root);

      Console.WriteLine();

      yay.PreOrder(Root);

      Console.ReadKey();

    }
  }
}
