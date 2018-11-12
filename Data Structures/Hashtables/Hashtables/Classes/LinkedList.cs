using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
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
    public Node(KeyValue data)
    {
      Data = data;
    }
  }

  public class LinkList
  {
    public Node Head;
    public Node Current;

    /// <summary>
    /// prints every node out
    /// </summary>
    public void PrintAllNodes()
    {
      try
      {
        Current = Head;
        while (Current != null)
        {
          Console.WriteLine(Current.Data);
          Current = Current.Next;
        }
      }
      catch (Exception)
      {
        Console.WriteLine("Operation has run into an error.");
      }
    }
    /// <summary>
    /// add nodes to the head of the Linked List
    /// </summary>
    /// <param name="node">node to want to add to head</param>
    public void AddToHead(Node node)
    {
      try
      {
        Current = Head;
        node.Next = Head;
        Head = node;
        Current = Head;
      }
      catch (Exception)
      {
        Console.WriteLine("Operation has run into an error.");
      }
    }
    /// <summary>
    /// Adds node to the end of the link list
    /// </summary>
    /// <param name="node">node you want to add</param>
    public void Append(Node node)
    {
      try
      {
        if (Head == null)
        {
          Head = node;
          Head.Next = null;
        }
        else
        {
          Current = Head;
          while (Current.Next != null)
          {
            Current = Current.Next;
          }

          Current.Next = node;
          Current = Head;
        }
      }
      catch (Exception)
      {
        Console.WriteLine("Operation has run into an error.");
      }
    }
    /// <summary>
    /// add new node before specified existing node
    /// </summary>
    /// <param name="newNode">node you want to add</param>
    /// <param name="existingNode">specified node you want to add new node before</param>
    public void AddBefore(Node newNode, Node existingNode)
    {
      if (newNode.Next != null)
      {
        Console.WriteLine("Please ensure your input Nodes do not already contain references to other nodes.");
        newNode.Next = null;
      }
      else
      {
        try
        {
          Current = Head;
          if (Current.Data == existingNode.Data)
          {
            AddToHead(newNode);
            return;
          }

          while (Current.Next != null)
          {
            if (Current.Next.Data == existingNode.Data)
            {
              newNode.Next = Current.Next;
              Current.Next = newNode;
              return;
            }
            Current = Current.Next;
          }
        }
        catch (Exception)
        {
          Console.WriteLine("Please input a Node type");
        }
      }
    }
    /// <summary>
    /// Adds a new node after a specified exsiting node
    /// </summary>
    /// <param name="newNode">node you want to insert</param>
    /// <param name="existingNode">node you want to insert new node after</param>
    public void AddAfter(Node newNode, Node existingNode)
    {
      if (newNode.Next != null)
      {
        Console.WriteLine("Please ensure your input Nodes do not already contain references to other nodes.");
      }
      else
      {
        try
        {
          Current = Head;
          while (Current != null)
          {
            if (Current.Data == existingNode.Data)
            {
              newNode.Next = Current.Next;
              Current.Next = newNode;
              return;
            }
            Current = Current.Next;
          }
        }
        catch (Exception)
        {
          Console.WriteLine("Operation has run into an error.");
        }
      }
    }
    /// <summary>
    /// search for specified data in list
    /// returns true or false
    /// </summary>
    /// <param name="data">data searched for</param>
    /// <returns></returns>
    public bool Includes(object data)
    {
      try
      {
        Current = Head;
        while (Current != null)
        {
          if (Current.Data == data)
          {
            return true;
          }
          Current = Current.Next;
        }
        return false;
      }
      catch (Exception)
      {
        Console.WriteLine("Operation has run into an error.");
        throw;
      }
    }
  }
}
