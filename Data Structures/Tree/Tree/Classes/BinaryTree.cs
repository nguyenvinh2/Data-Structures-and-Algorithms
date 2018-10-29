using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
  public class BinaryTree
  {
    /// <summary>
    /// public interface for traversal functions
    /// </summary>
    /// <param name="Root">root node to traverse</param>
    /// <returns></returns>
    public static List<int> InOrder(Node Root)
    {
      List<int> Stored = new List<int>();
      return InOrder(Root, Stored);
    }

    /// <summary>
    /// public interface for traversal functions
    /// </summary>
    /// <param name="Root">root node to traverse</param>
    /// <returns></returns>
    public static List<int> PostOrder(Node Root)
    {
      List<int> Stored = new List<int>();
      return PostOrder(Root, Stored);
    }

    /// <summary>
    /// public interface for traversal functions
    /// </summary>
    /// <param name="Root">root node to traverse</param>
    /// <returns></returns>
    public static List<int> PreOrder(Node Root)
    {
      List<int> Stored = new List<int>();
      return PreOrder(Root, Stored);
    }

    /// <summary>
    /// prints out values in pre order method
    /// </summary>
    /// <param name="Root">root node</param>
    static List<int> PreOrder(Node Root, List<int> Stored)
    {
      if (Root != null)
      {
        Stored.Add(Root.Data);
        PreOrder(Root.Left, Stored);
        PreOrder(Root.Right, Stored);
      }
      return Stored;
    }
    /// <summary>
    /// prints out values in a in order method
    /// </summary>
    /// <param name="Root">root node</param>
    static List<int> InOrder(Node Root, List<int> Stored)
    {
      if (Root != null)
      {
        InOrder(Root.Left, Stored);
        Stored.Add(Root.Data);
        InOrder(Root.Right, Stored);
      }
      return Stored;
    }
    /// <summary>
    /// prints out values in a post order method
    /// </summary>
    /// <param name="Root">root node of tree</param>
    static List<int> PostOrder(Node Root, List<int> Stored)
    {
      if (Root != null)
      {
        PostOrder(Root.Left, Stored);
        PostOrder(Root.Right, Stored);
        Stored.Add(Root.Data);
      }
      return Stored;
    }
  }
}
