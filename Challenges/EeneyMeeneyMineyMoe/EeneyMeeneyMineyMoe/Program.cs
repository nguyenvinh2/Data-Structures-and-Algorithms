using System;
using System.Collections.Generic;
using StackAndQueue.Classes;

namespace EeneyMeeneyMineyMoe
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      List<string> Names = new List<string>() { "Bob", "Marley", "Stacy", "Vin", "Danny", "Molly", "Blake" };
      int n = -2;
      Console.WriteLine($"With an selection number of {n} and...");
      foreach (var x in Names)
      {
        Console.Write($"{x} ");
      }
      Console.WriteLine();
      Console.WriteLine($"Retuns {(string)EeneyMeeneyMineyMoe(n, Names).Data}.");
      Console.ReadKey();
    }

    public static Node EeneyMeeneyMineyMoe(int number, List<string> input)
    {
      if (number <= 0)
      {
        return new Node(null);
      }

      Queue Handler = new Queue(new Node("Initialize"));
      foreach (var x in input)
      {
        Handler.Enqueue(new Node(x));
      }

      Node Final = new Node("Dummy");
      int count = 0;

      while (Handler.Front != null)
      {
        count++;
        if (count == number)
        {
          Final = Handler.Dequeue();
          count = 0;
          continue;
        }
        Handler.Enqueue(Handler.Dequeue());
      }
      return Final;
    }
  }
}
