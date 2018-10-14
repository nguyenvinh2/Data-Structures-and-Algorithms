using System;
using Xunit;
using fibonnaciSequence;
using static fibonnaciSequence.Program;

namespace XUnitTestFibonnaci
{
  public class UnitTest1
  {
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    [InlineData(20, 6765)]
    [InlineData(30, 832040)]
    [InlineData(40, 102334155)]
    public void RangeMatch(uint input, uint expected)
    {
      Assert.Equal(expected, Fibonacci(input));
    }
  }
}
