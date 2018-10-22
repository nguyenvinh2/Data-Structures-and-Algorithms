using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
  public class Queue
  {
    /// <summary>
    /// establishes the two nodes for operation, the FRONT node and the REAR node
    /// </summary>
    public Node Front { get; set; }
    public Node Rear { get; set; }
    /// <summary>
    /// constructor for queue class, with one node, it becomes both the front and rear node
    /// </summary>
    /// <param name="node">first node you want to initiate your queue with</param>
    public Queue(Node node)
    {
      Front = node;
      Rear = node;
    }
    /// <summary>
    /// the front node you want to look at
    /// </summary>
    /// <returns>the front node</returns>
    public Node Peek()
    {
      return Front;
    }
    /// <summary>
    /// adds the latest node to the back or "rear" of the queue
    /// </summary>
    /// <param name="node">the node you want to add to the queue</param>
    public void Enqueue(Node node)
    {
      Rear.Next = node;
      Rear = node;
    }
    /// <summary>
    /// removes the node at the front of the queue, satisfying the FIFO principle
    /// </summary>
    /// <returns>the node being removed</returns>
    public Node Dequeue()
    {
      if (Front == null)
      {
        return null;
      }
      Node Current = Front;
      Front = Front.Next;
      Current.Next = null;
      return Current;
    }
  }
}
