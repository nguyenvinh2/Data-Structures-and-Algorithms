using System;

namespace arrayBinarySearch
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[] arrayIn = {6,7,8,9,10,11,12,13,14,15,16,17,18};
      int numberIn = 0;
      Console.WriteLine(BinarySearch(arrayIn, numberIn));
      Console.ReadKey();
    }
    /// <summary>
    /// does binary search of the input array
    /// compare array value at middle index to input number
    /// searchs half of the array that the input number is known in
    /// only works if array is sorted from lowest to highest
    /// </summary>
    /// <param name="arrayIn">the input array</param>
    /// <param name="numberIn">the input number</param>
    /// <returns>the index of the input array that the input number is found in</returns>
    public static int BinarySearch(int[] arrayIn, int numberIn)
    {
      int indexHigh = arrayIn.Length - 1;
      int indexLow = 0;
      int indexMiddle = (indexHigh + indexLow) / 2;
      //will run until input number is found in array
      //or there is nothing left to search
      while (indexLow <= indexHigh)
      {
        if (arrayIn[indexMiddle] == numberIn)
        {
          return indexMiddle;
        }
        if (arrayIn[indexMiddle] < numberIn)
        {
          indexLow = indexMiddle + 1;
          indexMiddle = (indexHigh + indexLow) / 2;
        }
        if (arrayIn[indexMiddle] > numberIn)
        {
          indexHigh = indexMiddle - 1;
          indexMiddle = (indexHigh + indexLow) / 2;
        }
      }
      return -1;
    }
  }
}
