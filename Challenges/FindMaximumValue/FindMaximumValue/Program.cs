using System;
using Tree.Classes;

namespace FindMaximumValue
{
  public class Program
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
    /// <summary>
    /// sets up the return output to pass to the pre order traversal method
    /// </summary>
    /// <param name="Root">root of tree</param>
    /// <returns>the max value in tree</returns>
    public static int FindMaxValue(Node Root)
    {
      if (Root != null)
      {
        int maxOutput = Root.Data;

        maxOutput = FindMaxValue(Root, maxOutput);
        return maxOutput;
      }
      else
      {
        return 0;
      }
    }
    /// <summary>
    /// pre order traveling to evaluate each node
    /// </summary>
    /// <param name="Root">base node</param>
    /// <param name="maxOutput">the max value in tree so far</param>
    /// <returns></returns>
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
