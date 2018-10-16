using System;
using LinkedList;

namespace LKthFromEnd
{
  public class Program
  {
    static void Main(string[] args)
    {
      int input = 5;
      Console.WriteLine("Hello World!");
      Console.WriteLine($"Input: {input}");
      KthSearch(input);
      Console.ReadKey();
    }

    public static Node KthSearch(int input)
    {
      LinkList InputList = new LinkList();
      InputList.Append(new Node("Something"));
      InputList.Append(new Node("Has"));
      InputList.Append(new Node("Gone"));
      InputList.Append(new Node("Wrong"));
      InputList.Append(new Node("Charlie"));
      InputList.Append(new Node("Dan"));
      InputList.Append(new Node("Stan"));
      InputList.printAllNodes();

      int length = 0;
      Node current = InputList.Head;
      while (current != null)
      {
        length++;
        current = current.Next;
      }

      try
      {
        NumberCheck(input, length);
        current = InputList.Head;
        for (int i = 0; i < length - input - 1; i++)
        {
          current = current.Next;
        }
        Console.WriteLine($"The Node at Position {input} from the end is {current.Data}");
        return current;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return new Node(null);
      }
    
    }

    public static void NumberCheck(int input, int length)
    {
      if (input >= length)
      {
        throw new Exception("Your Input must not be greater than the length of the List.");
      }
      else if (input < 0)
      {
        throw new Exception("Your Input must not be negative.");
      }
    }
  }
}
