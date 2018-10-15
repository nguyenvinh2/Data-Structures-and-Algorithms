using System;

namespace fibonnaciSequence
{
  public class Program
  {
    /// <summary>
    /// calls three implementation of fibonacci
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      uint input = 25;
      Console.WriteLine(input);
      Console.WriteLine(Fibonacci(input));
      Console.WriteLine(FibonacciConstant(input));
      Console.WriteLine(FibonacciRecursive(input));
      Console.ReadKey();
    }
    /// <summary>
    /// for loop fibonacci implementation
    /// </summary>
    /// <param name="input">sequence input</param>
    /// <returns></returns>
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
    /// <summary>
    /// fibonacci based on formula
    /// constant operation
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static uint FibonacciConstant(uint input)
    {
      double phi = (Math.Sqrt(5) + 1) / 2;
      uint fibonacci = (uint)((Math.Pow(phi, input) - Math.Pow(-phi, -input)) / Math.Sqrt(5)); ;
      return fibonacci;
    }
    /// <summary>
    /// recursive implementation
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static uint FibonacciRecursive(uint input)
    {
      if (input == 0)
      {
        return 0;
      }
      if (input == 1)
      {
        return 1;
      }
      return FibonacciRecursive(input - 1) + FibonacciRecursive(input - 2);
    }
  }
}
