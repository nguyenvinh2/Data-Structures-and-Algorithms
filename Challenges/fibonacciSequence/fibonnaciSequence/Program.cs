using System;

namespace fibonnaciSequence
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      uint input = 45;
      Console.WriteLine(input);
      Console.WriteLine(Fibonacci(input));
      Console.ReadKey();
    }

    public static uint Fibonacci(uint input)
    {
      try
      {
        uint fibonnaci = 1;
        uint priorValue = 1;
        uint placeholder;
        if (input == 0)
        {
          return 0;
        }
        if (input == 1)
        {
          return 1;
        }
        for (int i = 2; i < input; i++)
        {
          placeholder = fibonnaci;
          fibonnaci += priorValue;
          priorValue = placeholder;
        }
        return fibonnaci;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        throw;
      }

    }
  }
}
