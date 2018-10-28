using System;
using System.Collections.Generic;
using StackAndQueue.Classes;

namespace EeneyMeeneyMineyMoe
{
  public class Program
  {
    /// <summary>
    /// run example on queue
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      List<string> Names = new List<string>() { "Bob", "Marley", "Stacy", "Vin", "Danny", "Molly", "Blake" };
      int n = 4;
      Console.WriteLine($"With an selection number of {n} and...");
      foreach (var x in Names)
      {
        Console.Write($"{x} ");
      }
      Console.WriteLine();
      Console.WriteLine($"Returns {(string)EeneyMeeneyMineyMoeMethod(n, Names).Data}.");
      Console.ReadKey();
    }
    /// <summary>
    /// puts lists into queue
    /// slowly reduces the queue to one value based on input number
    /// count starts with one, goes up by one every sequence, resets when
    /// it deques an item
    /// queue always need atleast one item to work properly
    /// hence the Node "initialize"
    /// this is ignored in the while loop
    /// </summary>
    /// <param name="number">position to deque</param>
    /// <param name="input">string of names</param>
    /// <returns></returns>
    public static Node EeneyMeeneyMineyMoeMethod(int number, List<string> input)
    {
      if (input == null)
      {
        return new Node(null);
      }
      if (number <= 0)
      {
        return new Node(null);
      }

      Queue Handler = new Queue(new Node("Initialize"));
      foreach (var x in input)
      {
        Handler.Enqueue(new Node(x));
      }
      Node Final = new Node(null);
      int count = 1;
     
      while (Handler.Front != null)
      {
        if (count == number && (string)Handler.Front.Data != "Initialize")
        {
          Final = Handler.Dequeue();
          count = 1;
        }
        else if ((string)Handler.Front.Data == "Initialize")
        {
          Handler.Enqueue(Handler.Dequeue());
        }
        else
        {
          Handler.Enqueue(Handler.Dequeue());
          count++;
        }
      }
      return Final;
    }
  }
}
