using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue;
using StackAndQueue.Classes;

namespace QueueWithStacks.Classes
{
  public class Queue
  {
    public Stack FrontStack = new Stack(null);
    public Stack RearStack = new Stack(null);

    /// <summary>
    /// method to dequeue using two stacks
    /// works by shuffling one stack onto the other
    /// adds input to first stack, then shuffles back.
    /// </summary>
    /// <param name="node">takes input node</param>
    public void Enqueue(Node node)
    {
      if (node == null)
      {
        Console.WriteLine("Please don't add a null value");
      }
      else
      {
        while (FrontStack.Top !=null)
        {
          Node Temp = FrontStack.Top.Next;
          RearStack.Push(FrontStack.Top);
          FrontStack.Top = Temp;
        }
        FrontStack.Push(node);
        while (RearStack.Top != null)
        {
          Node Temp2 = RearStack.Top.Next;
          FrontStack.Push(RearStack.Top);
          RearStack.Top = Temp2;
        }
      }
    }
    /// <summary>
    /// Removes the Front node
    /// </summary>
    /// <returns>the top node of the stack</returns>
    public Node Dequeue()
    {
      FrontStack.Pop();
      return FrontStack.Top;
    }
    /// <summary>
    /// look at front node
    /// </summary>
    /// <returns>gives the first node added</returns>
    public Node Peek()
    {
      return FrontStack.Top;
    }
    /// <summary>
    /// counts how many nodes in the queue
    /// </summary>
    /// <returns>integer count of nodes</returns>
    public int GetSize()
    {
      int count = 0;
      while (FrontStack.Top != null)
      {
        count++;
        FrontStack.Top = FrontStack.Top.Next;
      }
      return count;
    }
  }
}
