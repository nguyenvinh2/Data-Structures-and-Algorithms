using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
  public class BinarySearchTree
  {
    public Node Root;
    /// <summary>
    /// recursive function. adds input as a node to tree
    /// if position is already occupied, adds it to the left or right
    /// depending on value
    /// </summary>
    /// <param name="input">value added</param>
    /// <returns>node with the value added</returns>
    public void Add(int input)
    {
      Node TempNode = new Node();
      bool Run = true;
      TempNode.Data = input;
      if (Root == null)
        Root = TempNode;
      else
      {
        Node Current = Root;
        Node BaseNode;
        while (Run)
        {
          BaseNode = Current;
          if (input < Current.Data)
          {
            Current = Current.Left;
            if (Current == null)
            {
              BaseNode.Left = TempNode;
              Run = false;
            }
          }
          else
          {
            Current = Current.Right;
            if (Current == null)
            {
              BaseNode.Right = TempNode;
              Run = false;
            }
          }
        }
      }
    }
    /// <summary>
    /// conducts binary search on the data structure, returns the result.
    /// </summary>
    /// <param name="search">value being searched</param>
    /// <returns>node with the value</returns>
    public Node Search(int search)
    {

      if (Root == null || Root.Data == search)
      {
        return Root;
      }
     
      if (Root.Data < search)
      {
        Root = Root.Right;
        return Search(search);
      }
      else
      {
        Root = Root.Left;
        return Search(search);
      }
    }
  }

}

