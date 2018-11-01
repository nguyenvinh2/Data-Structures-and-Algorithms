using System;
using Xunit;
using FindMaximumValue;
using static FindMaximumValue.Program;
using Tree.Classes;

namespace XUnitTestFindMaxValue
{
  public class UnitTest1
  {
    /// <summary>
    /// general max value test
    /// </summary>
    [Fact]
    public void MaxValueTest()
    {
      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(55);
      TreeRoot.Left = new Tree.Classes.Node(56);
      TreeRoot.Right = new Tree.Classes.Node(57);
      TreeRoot.Left.Left = new Tree.Classes.Node(58);
      TreeRoot.Left.Right = new Tree.Classes.Node(59);
      TreeRoot.Right.Left = new Tree.Classes.Node(60);
      TreeRoot.Right.Right = new Tree.Classes.Node(61);

      int value = FindMaxValue(TreeRoot);

      Assert.Equal(61, value);
    }
    /// <summary>
    /// null root node is set to return 0
    /// </summary>
    [Fact]
    public void NullTest()
    {
      Tree.Classes.Node TreeRoot = null;

      int value = FindMaxValue(TreeRoot);

      Assert.Equal(0, value);
    }
    /// <summary>
    /// test to evaluate negative values
    /// </summary>
    [Fact]
    public void MaxNegativeValueTest()
    {
      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(-55);
      TreeRoot.Left = new Tree.Classes.Node(-56);
      TreeRoot.Right = new Tree.Classes.Node(-57);
      TreeRoot.Left.Left = new Tree.Classes.Node(-48);
      TreeRoot.Left.Right = new Tree.Classes.Node(-59);
      TreeRoot.Right.Left = new Tree.Classes.Node(-60);
      TreeRoot.Right.Right = new Tree.Classes.Node(-61);

      int value = FindMaxValue(TreeRoot);

      Assert.Equal(-48, value);
    }
  }
}
