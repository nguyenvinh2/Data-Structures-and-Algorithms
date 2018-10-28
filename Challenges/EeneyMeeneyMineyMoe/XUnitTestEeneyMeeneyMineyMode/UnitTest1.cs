using System;
using Xunit;
using System.Collections.Generic;
using StackAndQueue.Classes;
using EeneyMeeneyMineyMoe;
using static EeneyMeeneyMineyMoe.Program;

namespace XUnitTestEeneyMeeneyMineyMode
{
  /// <summary>
  /// tests the method to return the right name depending on number
  /// </summary>
  public class UnitTest1
  {
    [Theory]
    [InlineData(1, "Blake")]
    [InlineData(2, "Blake")]
    [InlineData(3, "Vin")]
    [InlineData(4, "Marley")]
    [InlineData(5, "Molly")]
    [InlineData(6, "Stacy")]
    [InlineData(7, "Danny")]
    [InlineData(8, "Vin")]
    public void QueueNumberTest(int input, string name)
    {
      List<string> Names = new List<string>() { "Bob", "Marley", "Stacy", "Vin", "Danny", "Molly", "Blake" };
      Node Test = EeneyMeeneyMineyMoeMethod(input, Names);
      Assert.Equal(name, (string)Test.Data);
    }
    /// <summary>
    /// tests for a 0 number input
    /// </summary>
    [Fact]
    public void NumberNullTest()
    {
      List<string> Names = new List<string>() { "Bob", "Marley", "Stacy", "Vin", "Danny", "Molly", "Blake" };
      Node Test = EeneyMeeneyMineyMoeMethod(0, Names);
      Assert.Null(Test.Data);
    }
    /// <summary>
    /// tests if has no names in the list
    /// </summary>
    [Fact]
    public void StringNullTest()
    {
      List<string> Names = new List<string>();
      Node Test = EeneyMeeneyMineyMoeMethod(1, Names);
      Assert.Null(Test.Data);
    }
  }
}
