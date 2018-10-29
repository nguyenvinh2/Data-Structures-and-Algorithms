using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
  public class Node
  {
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node()
    {
    }

    /// <summary>
    ///     constructor for node with data
    /// </summary>
    public Node(int input)
    {
      Data = input;
    }
  }
}
