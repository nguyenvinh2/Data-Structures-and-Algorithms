using System;
using LinkedList;

namespace llMerge
{
  class Program
  {
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

      Two.Append(new Node("One"));
      Two.Append(new Node("Two"));
      Two.Append(new Node("Three"));
      Two.Append(new Node("Four"));

      LinkList Three = AlterMerge(One, Two);
      Three.Current = Three.Head;
      while (Three.Current != null)
      {
        Console.WriteLine(Three.Current.Data);
        Three.Current = Three.Current.Next;
      }
      Console.ReadKey();
    }
    public static LinkList AlterMerge(LinkList One, LinkList Two)
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
