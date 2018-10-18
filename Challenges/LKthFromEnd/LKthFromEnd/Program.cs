using System;
using LinkedList;

namespace LKthFromEnd
{
  public class Program
  {
    /// <summary>
    /// creates dummy Link List for testing
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      int input = 3;
      Console.WriteLine("Hello World!");
      Console.WriteLine($"Input: {input}");

      LinkList InputList = new LinkList();
      InputList.Append(new Node("Something"));
      InputList.Append(new Node("Has"));
      InputList.Append(new Node("Gone"));
      InputList.Append(new Node("Wrong"));
      InputList.Append(new Node("Charlie"));
      InputList.Append(new Node("Dan"));
      InputList.Append(new Node("Stan"));
      InputList.PrintAllNodes();

      KthSearch(input, InputList);
      Console.ReadKey();
    }
    /// <summary>
    /// returns node at specified k value from end of link list
    /// </summary>
    /// <param name="input">k value</param>
    /// <param name="List">input Link List</param>
    /// <returns></returns>
    public static Node KthSearch(int input, LinkList List)
    {

      int length = 0;
      Node current = List.Head;
      while (current != null)
      {
        length++;
        current = current.Next;
      }

      try
      {
        NumberCheck(input, length);
        current = List.Head;
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
        return null;
      }
    
    }
    /// <summary>
    /// catches out of range k element inputs
    /// </summary>
    /// <param name="input">k vale</param>
    /// <param name="length">size of link list</param>
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
