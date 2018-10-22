using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
  public class Stack
  {
    public Node Top { get; set; }
    /// <summary>
    /// constructor for stack class
    /// </summary>
    /// <param name="node">first node you want to initiate in your stack</param>
    public Stack(Node node)
    {
      Top = node;
    }
    /// <summary>
    /// just gets the top node;
    /// </summary>
    /// <returns>the top node</returns>
    public Node Peek()
    {
      return Top;
    }
    /// <summary>
    /// remove the top node
    /// </summary>
    /// <returns></returns>
    public Node Pop()
    {
      //account for null exception
      if (Top == null)
      {
        return null;
      }
      //peeks than remove nodes
      Node Current = Top;
      Top = Top.Next;
      Current.Next = null;
      return Current;
    }
    /// <summary>
    /// adds the latest node to the stack
    /// </summary>
    /// <param name="node">the node being added</param>
    public void Push(Node node)
    {
      //this prevents user from messing up the data structure by trying to add a null node
      if (node == null)
      {
        Console.WriteLine("You cannot add a null value to the Stack");
      }
      else
      {
        node.Next = Top;
        Top = node;
      }
    }
  }
}
