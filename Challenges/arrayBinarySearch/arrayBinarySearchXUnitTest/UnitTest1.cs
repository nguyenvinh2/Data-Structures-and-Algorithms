using System;
using Xunit;
using arrayBinarySearch;
using static arrayBinarySearch.Program;

namespace arrayBinarySearchXUnitTest
{
  public class UnitTest1
  {
    //empty array will return -1 or not found
    [Fact]
    public void EmptyArrayTest()
    {
      Assert.Equal(-1, BinarySearch(new int[] { }, 5));
    }
    //test for searching on the right half of the array
    [Fact]
    public void RandomHighValueArrayTest()
    {
      Assert.Equal(4, BinarySearch(new int[] {1,2,2,2,5}, 5));
    }
    //test for search on the left half of the array
    [Fact]
    public void RandomLowValueArrayTest()
    {
      Assert.Equal(1, BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 2));
    }
    //makes sure this works on array of 1 element
    [Fact]
    public void SingleArrayTest()
    {
      Assert.Equal(0, BinarySearch(new int[] {2}, 2));
    }
    //similar as previous test but expecting not found value
    [Fact]
    public void SingleArrayNotFoundTest()
    {
      Assert.Equal(-1, BinarySearch(new int[] { 2 }, 3));
    }
    //tests method against 100 element array
    //element in array is from 0-99
    [Fact]
    public void HunderedElementArrayTest()
    {
      int[] testArray = new int[100];
      for (int i = 0; i < testArray.Length; i++)
      {
        testArray[i] = i;
      }
      Assert.Equal(5, BinarySearch(testArray, 5));
    }
    //tests method against 10,000 element array
    //element in array is from 0-9999
    [Fact]
    public void ThousandElementArrayTest()
    {
      int[] testArray = new int[10000];
      for (int i = 0; i < testArray.Length; i++)
      {
        testArray[i] = i;
      }
      Assert.Equal(7600, BinarySearch(testArray, 7600));
    }
    //tests method against 100000 element array
    //element in array is from 0-99999
    [Fact]
    public void HundredThousandElementArrayTest()
    {
      int[] testArray = new int[100000];
      for (int i = 0; i < testArray.Length; i++)
      {
        testArray[i] = i;
      }
      Assert.Equal(17600, BinarySearch(testArray, 17600));
    }
  }
}
