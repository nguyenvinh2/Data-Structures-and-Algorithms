using System;
using LinkedList;

namespace llReverse
{
  public class Program
  {
    /// <summary>
    /// creates inputs to test method
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      LinkList Input = new LinkList();
      Input.Append(new Node("Aaaah"));
      Input.Append(new Node("Baaah"));
      Input.Append(new Node("Caaah"));
      Input.Append(new Node("Daaah"));
      Input.Append(new Node("Eaaah"));
      Input.Append(new Node("Faaah"));

      Input.PrintAllNodes();
      Console.WriteLine();
      LinkList Output = LLReverse(Input);
      Output.PrintAllNodes();
      Console.ReadKey();
    }
    /// <summary>
    /// utilizes temporary pointers to reverse the direction of the link lists 
    /// </summary>
    /// <param name="Input">input link list</param>
    /// <returns>link list with order reversed</returns>
    public static LinkList LLReverse(LinkList Input)
    {
      Node Previous = null;
      Node NextTemp;
      Input.Current = Input.Head;
      while (Input.Current != null)
      {
        NextTemp = Input.Current.Next;
        Input.Current.Next = Previous;
        Previous = Input.Current;
        Input.Current = NextTemp;
      }
      Input.Head = Previous;
      return Input;
    }
  }
}
