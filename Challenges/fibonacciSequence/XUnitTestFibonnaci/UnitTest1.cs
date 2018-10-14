using System;
using Xunit;
using fibonnaciSequence;
using static fibonnaciSequence.Program;

namespace XUnitTestFibonacci
{
  public class UnitTest1
  {
    /// <summary>
    /// range test for exepect fibonacci value base on input
    /// for loop case
    /// </summary>
    /// <param name="input">input number</param>
    /// <param name="expected">expected sequency value</param>
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    [InlineData(20, 6765)]
    [InlineData(30, 832040)]
    [InlineData(40, 102334155)]
    public void RangeMatchFibonacci(uint input, uint expected)
    {
      Assert.Equal(expected, Fibonacci(input));
    }

    /// <summary>
    /// same range test for exepect fibonacci value base on input
    /// for O(1) case
    /// </summary>
    /// <param name="input"></param>
    /// <param name="expected"></param>
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    [InlineData(20, 6765)]
    [InlineData(30, 832040)]
    [InlineData(40, 102334155)]
    public void RangeMatchConstant(uint input, uint expected)
    {
      Assert.Equal(expected, FibonacciConstant(input));
    }

    /// <summary>
    /// same range test for exepect fibonacci value base on input
    /// for recursive case
    /// </summary>
    /// <param name="input"></param>
    /// <param name="expected"></param>
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    [InlineData(20, 6765)]
    [InlineData(30, 832040)]
    [InlineData(40, 102334155)]
    public void RangeMatchRecursive(uint input, uint expected)
    {
      Assert.Equal(expected, FibonacciRecursive(input));
    }
  }
}

