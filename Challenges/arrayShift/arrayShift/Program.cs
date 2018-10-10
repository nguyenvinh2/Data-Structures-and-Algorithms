using System;

namespace arrayShift
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[] arrayInput = {1,2,3,4,5,6};
      int numberInput = 0;
      foreach (int element in ArrayShift(arrayInput, numberInput))
      {
        Console.Write($"{element} ");
      }

      Console.ReadKey();
    }

    static int[] ArrayShift(int[] arrayIn, int numberIn)
    {
      float index = (float)arrayIn.Length / 2;
      int indexConversion = (int)Math.Ceiling(index);
      int[] output = new int[arrayIn.Length + 1];

      for (int i = 0; i < output.Length; i++)
      {
        if (i < indexConversion)
        {
          output[i] = arrayIn[i];
        }
        if (i == indexConversion)
        {
          output[i] = numberIn;
        }
        if (i > indexConversion)
        {
          output[i] = arrayIn[i - 1];
        }
      }

      return output;
    }
  }
}
