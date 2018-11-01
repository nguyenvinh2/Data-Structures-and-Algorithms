using System;
using Tree.Classes;

namespace FindMaximumValue
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(55);
      TreeRoot.Left = new Tree.Classes.Node(56);
      TreeRoot.Right = new Tree.Classes.Node(57);
      TreeRoot.Left.Left = new Tree.Classes.Node(58);
      TreeRoot.Left.Right = new Tree.Classes.Node(59);
      TreeRoot.Right.Left = new Tree.Classes.Node(60);
      TreeRoot.Right.Right = new Tree.Classes.Node(61);

      int value = FindMaxValue(TreeRoot);
      Console.WriteLine(value);

      Console.ReadKey();
    }

    public static int FindMaxValue(Node Root)
    {
      int maxOutput = Root.Data;
      maxOutput = FindMaxValue(Root, maxOutput);
      return maxOutput;
    }

    public static int FindMaxValue(Node Root, int maxOutput)
    {
      if (Root != null)
      {
        if (Root.Data > maxOutput)
        {
          maxOutput = Root.Data;
        }
        maxOutput = FindMaxValue(Root.Left, maxOutput);
        maxOutput = FindMaxValue(Root.Right, maxOutput);
      }
      return maxOutput;
    }
  }
}
