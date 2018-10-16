using System;
using LinkedList;

namespace LKthFromEnd
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      KthSearch(5);
    }

    public static void KthSearch(int input)
    {
      LinkList InputList = new LinkList();
      InputList.Append(new Node("Something"));
      InputList.Append(new Node("Has"));
      InputList.Append(new Node("Gone"));
      InputList.Append(new Node("Wrong"));
      InputList.Append(new Node("Charlie"));

      InputList.printAllNodes();
      Console.ReadKey();
      int counter = 0;

      Node current = InputList.Head;
      while (current != null)
      {
        counter++;
      }


    }
  }
}
