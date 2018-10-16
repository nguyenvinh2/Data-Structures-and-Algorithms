using System;

namespace LinkedList
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
    public Node(object data)
    {
      Data = data;
    }
  }

  public class LinkedList
  {
    public Node Head;
    public Node Current;

    /// <summary>
    /// prints every node out
    /// </summary>
    public void printAllNodes()
    {
      Current = Head;
      while (Current != null)
      {
        Console.WriteLine(Current.Data);
        Current = Current.Next;
      }
    }
    /// <summary>
    /// add nodes to the head of the Linked List
    /// </summary>
    /// <param name="node">node to want to add to head</param>
    public void AddToHead(Node node)
    {
      Current = Head;
      node.Next = Head;
      Head = node;
      Current = Head;
    }
    /// <summary>
    /// Adds node to the end of the link list
    /// </summary>
    /// <param name="node"></param>
    public void AddToEnd(Node node)
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
        Console.WriteLine("Please input a Node type");
      }
    }

    public void AddBefore(Node newNode, Node existingNode)
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

    public void AddAfter(Node newNode, Node existingNode)
    {
      try
      {
        Current = Head;
        if (Current.Data == existingNode.Data)
        {
          newNode.Next = Current.Next;
          Current.Next = newNode;
          return;
        }

        while (Current.Next != null)
        {
          if (Current.Next.Data == existingNode.Data)
          {
            newNode.Next = Current.Next.Next;
            Current.Next.Next = newNode;
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

    public Node Traverse(int number)
    {
      try
      {
        Current = Head;
        for (int i = 0; i < number; i++)
        {
          Current = Current.Next;
        }
        return Current;
      }
      catch
      {
        Console.WriteLine("Please input a Node type");
        throw;
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Console.WriteLine("Add First:");
      LinkedList myList1 = new LinkedList();

      myList1.AddToHead(new Node("Hello"));
      myList1.AddToHead(new Node("Magical"));
      myList1.AddToHead(new Node("World"));
      myList1.printAllNodes();

      Console.WriteLine();

      Node Magic = new Node("Hello");
      Node Add = new Node("Lisa");

      myList1.AddBefore(Add, Magic);
      myList1.AddAfter(Add, Magic);
      myList1.printAllNodes();

      Console.WriteLine();

      Console.WriteLine("Add Last:");
      myList1.AddToEnd(new Node("Don't"));
      myList1.AddToEnd(new Node("Be"));
      myList1.AddToEnd(new Node("Last"));
      myList1.printAllNodes();

      Console.WriteLine();

      Console.WriteLine(myList1.Traverse(2).Data);






      Console.ReadLine();
    }
  }
}
