using System;
using LinkedList;

namespace llMerge
{
  public class Program
  {
    /// <summary>
    /// first block is printout for data for input LL One
    /// second block is printout for data for input LL Two
    /// third block is printout for the merge results
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      LinkList One = new LinkList();
      LinkList Two = new LinkList();

      One.Append(new Node("A"));
      One.Append(new Node("B"));
      One.Append(new Node("C"));
      One.Append(new Node("D"));
      One.Append(new Node("E"));
      One.Append(new Node("F"));
      One.Append(new Node("G"));

      Console.WriteLine();

      One.Current = One.Head;
      while (One.Current != null)
      {
        Console.WriteLine(One.Current.Data);
        One.Current = One.Current.Next;
      }

      Two.Append(new Node("One"));
      Two.Append(new Node("Two"));
      Two.Append(new Node("Three"));
      Two.Append(new Node("Four"));

      Console.WriteLine();

      Two.Current = Two.Head;
      while (Two.Current != null)
      {
        Console.WriteLine(Two.Current.Data);
        Two.Current = Two.Current.Next;
      }

      LinkList Three = Merge(One, Two);
      Three.Current = Three.Head;

      Console.WriteLine();

      while (Three.Current != null)
      {
        Console.WriteLine(Three.Current.Data);
        Three.Current = Three.Current.Next;
      }
      Console.ReadKey();
    }
    /// <summary>
    /// accounts for null user inputs for one, the other, or both link lists
    /// if both lists are valid with proper nodes
    /// then the while loop is set up to repoint each node in one link list
    /// to the next node in the other link list
    /// will repeat until one link list runs out of node
    /// then the nodes will point at the remaining nodes in the other link
    /// list
    /// </summary>
    /// <param name="One">first LL input</param>
    /// <param name="Two">second LL input</param>
    /// <returns></returns>
    public static LinkList Merge(LinkList One, LinkList Two)
    {
      LinkList Result = new LinkList();

      if (One.Head == null && Two.Head != null)
      {
        Result = Two;
        return Result;
      }
      else if (One.Head != null && Two.Head == null)
      {
        Result = One;
        return Result;
      }
      else if (One.Head == null && Two.Head == null)
      {
        return Result;
      }
      else
      {
        Result.Head = One.Head;
        Result.Current = Result.Head;
        One.Current = One.Head;
        Two.Current = Two.Head;
        while (One.Current != null && Two.Current != null)
        {
          Node TempOne = One.Current.Next;
          Node TempTwo = Two.Current.Next;
          One.Current.Next = Two.Current;
          Two.Current.Next = TempOne;
          One.Current = TempOne;
          Two.Current = TempTwo;
        }
        return Result;
      }
    }
  }
}
