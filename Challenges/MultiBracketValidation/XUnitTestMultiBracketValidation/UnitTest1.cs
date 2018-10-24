using System;
using Xunit;
using StackAndQueue.Classes;
using MultiBracketValidation;
using static MultiBracketValidation.Program;

namespace XUnitTestMultiBracketValidation
{
  public class UnitTest1
  {
    /// <summary>
    /// String with no brackets would theoretically return true as everything is
    /// balanced, as it should be.
    /// </summary>
    [Fact]
    public void NoBracketTest()
    {
      string input = "soshkgswludghs";
      Assert.True(Program.MultiBracketValidation(input));
    }
    /// <summary>
    /// emptry string should also return true
    /// </summary>
    [Fact]
    public void NoStringTest()
    {
      string input = "";
      Assert.True(Program.MultiBracketValidation(input));
    }
    /// <summary>
    /// tests against various bracket combos
    /// for true case
    /// </summary>
    /// <param name="input">the string being evaluated</param>
    [Theory]
    [InlineData("{{{}}}")]
    [InlineData("{{()}}")]
    [InlineData("{[{}]}")]
    [InlineData("[[{ihdgs}]]")]
    [InlineData("[dsdgsd({asfaf}asfasf)aasfafasf]")]
    [InlineData("[]{}()()(())")]
    public void VariousTrueTest(string input)
    {
      Assert.True(Program.MultiBracketValidation(input));
    }
    /// <summary>
    /// tests case known to be false
    /// </summary>
    /// <param name="input">the string being evaluated</param>
    [Theory]
    [InlineData("{}}}")]
    [InlineData("{{{{{{}}}")]
    [InlineData("{{()}")]
    [InlineData("{{}]}")]
    [InlineData("{ihdgs}]]")]
    [InlineData("[dsdgsd({assfasf)aasfafasf]")]
    [InlineData("[}()()(())")]
    public void VariousFalseTest(string input)
    {
      Assert.False(Program.MultiBracketValidation(input));
    }
  }
}
