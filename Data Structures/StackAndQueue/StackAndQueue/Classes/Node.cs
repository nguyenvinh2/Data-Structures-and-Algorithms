using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
  /// <summary>
  /// same node as from linked list
  /// </summary>
  public class Node
  {
    /// <summary>
    /// node data property
    /// </summary>
    public object Data { get; set; }
    /// <summary>
    /// node next reference property
    /// </summary>
    public Node Next { get; set; }
    /// <summary>
    /// for instatiating Node
    /// </summary>
    /// <param name="data">object data user input</param>
    public Node(object data)
    {
      Data = data;
    }
  }
}
