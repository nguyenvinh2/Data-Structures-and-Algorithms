using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FizzBuzzTree
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Node Root = new Node(2);
      Node Fizz = new Node(3);
      Node FizzSix = new Node(6);
      Node BuzzTen = new Node(10);
      Node FizzBuzz = new Node(15);
      Node FizzBuzz30 = new Node(30);

      Node Four = new Node(4);
      Node Eight = new Node(8);
      Node Seven = new Node(7);

      Root.Left = Fizz;
      Root.Right = BuzzTen;

      Root.Left.Left = FizzSix;
      Root.Left.Right = Four;

      Root.Left.Left.Left = Eight;
      Root.Left.Left.Right = FizzBuzz;

      Root.Left.Right.Left = Seven;
      Root.Left.Right.Right = FizzBuzz30;

      List<int> PreOrderTraversal = BinaryTree.PreOrder(Root);
      Console.WriteLine("The integer values by PreOrder Traversal stored in the List is: ");
      foreach (var item in PreOrderTraversal)
      {
        Console.Write($"{item} ");
      }

      Console.WriteLine();

      List<string> FizzBuzzOutput = FizzBuzzTree(Root);

      Console.WriteLine();
      Console.WriteLine("The FizzBuzz values by PreOrder Traversal stored in the List is: ");
      foreach (var item in FizzBuzzOutput)
      {
        Console.Write($"{item} ");
      }
      Console.ReadKey();
    }
    /// <summary>
    /// this method is written solely to allow the fizz buzz output values to 
    /// be stored in a list for testing.
    /// </summary>
    /// <param name="Root">root of tree node</param>
    /// <returns>List of fizz buzz returns in the tree</returns>
    public static List<string> FizzBuzzTree(Node Root)
    {
      List<string> OutputValue = new List<string>();
      return FizzBuzzTreeOp(Root, OutputValue);
    }

    /// <summary>
    /// actually does the evaluation and traversal
    /// Uses preorder method to traverse through tree
    /// passes the node to a FizzBuzz method to evaluate
    /// for Fizz/Buzz.
    /// </summary>
    /// <param name="Root">root of input tree node</param>
    public static List<string> FizzBuzzTreeOp(Node Root, List<string> OutputValue)
    {
      if (Root != null)
      {
        OutputValue.Add(FizzBuzz(Root.Data));
        FizzBuzzTreeOp(Root.Left, OutputValue);
        FizzBuzzTreeOp(Root.Right, OutputValue);
      }
      return OutputValue;
    }

    public static string FizzBuzz(int value)
    {
      if (value % 3 == 0 && value % 5 != 0)
      {
        Console.Write("Fizz ");
        return "Fizz";
      }
      else if (value % 5 == 0 && value % 3 != 0)
      {
        Console.Write("Buzz ");
        return "Buzz";
      }
      else if (value % 5 == 0 && value % 3 == 0)
      {
        Console.Write("FizzBuzz ");
        return "FizzBuzz";
      }
      else
      {
        Console.Write($"{value} ");
        return (string)Convert.ToString(value);
      }

    }
  }
}
