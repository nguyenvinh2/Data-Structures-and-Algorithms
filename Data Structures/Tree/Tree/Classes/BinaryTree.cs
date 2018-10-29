using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
  class BinaryTree
  {
    /// <summary>
    /// prints out values in pre order method
    /// </summary>
    /// <param name="Root">root node</param>
    public void PreOrder(Node Root)
    {
      if (Root != null)
      {
        Console.Write(Root.Data + " ");
        PreOrder(Root.Left);
        PreOrder(Root.Right);
      }
    }
    /// <summary>
    /// prints out values in a in order method
    /// </summary>
    /// <param name="Root">root node</param>
    public void InOrder(Node Root)
    {
      if (Root != null)
      {
        InOrder(Root.Left);
        Console.Write(Root.Data + " ");
        InOrder(Root.Right);
      }
    }
    /// <summary>
    /// prints out values in a post order method
    /// </summary>
    /// <param name="Root">root node of tree</param>
    public void PostOrder(Node Root)
    {
      if (Root != null)
      {
        PostOrder(Root.Left);
        PostOrder(Root.Right);
        Console.Write(Root.Data + " ");
      }
    }
  }
}
