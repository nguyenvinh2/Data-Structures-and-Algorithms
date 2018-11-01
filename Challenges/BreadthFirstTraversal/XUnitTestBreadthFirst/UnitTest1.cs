using System;
using Xunit;
using Tree.Classes;
using StackAndQueue.Classes;
using System.Collections.Generic;
using static BreadthFirstTraversal.Program;

namespace XUnitTestBreadthFirst
{
  public class UnitTest1
  {
    /// <summary>
    /// Tests correct order of traversal
    /// </summary>
    /// <param name="value">node value at certain traversal</param>
    /// <param name="indices">index of List</param>
    [Theory]
    [InlineData(2, 0)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 4)]
    [InlineData(7, 5)]
    [InlineData(8, 6)]
    public void BreadthTraversalOrderTest(int value, int indices)
    {
      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(2);
      TreeRoot.Left = new Tree.Classes.Node(3);
      TreeRoot.Right = new Tree.Classes.Node(4);
      TreeRoot.Left.Left = new Tree.Classes.Node(5);
      TreeRoot.Left.Right = new Tree.Classes.Node(6);
      TreeRoot.Right.Left = new Tree.Classes.Node(7);
      TreeRoot.Right.Right = new Tree.Classes.Node(8);

      List<int> OutputList = BreadthFirst(TreeRoot);

      Assert.Equal(value, OutputList[indices]);
    }
    /// <summary>
    /// only nodes on left branch
    /// </summary>
    /// <param name="value"></param>
    /// <param name="indices"></param>
    [Theory]
    [InlineData(2, 0)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 4)]
    [InlineData(7, 5)]
    [InlineData(8, 6)]
    public void BreadthTraversalOrderLeftTest(int value, int indices)
    {
      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(2);
      TreeRoot.Left = new Tree.Classes.Node(3);
      TreeRoot.Left.Left = new Tree.Classes.Node(4);
      TreeRoot.Left.Left.Left = new Tree.Classes.Node(5);
      TreeRoot.Left.Left.Left.Left = new Tree.Classes.Node(6);
      TreeRoot.Left.Left.Left.Left.Left = new Tree.Classes.Node(7);
      TreeRoot.Left.Left.Left.Left.Left.Left= new Tree.Classes.Node(8);

      List<int> OutputList = BreadthFirst(TreeRoot);

      Assert.Equal(value, OutputList[indices]);
    }

    /// <summary>
    /// only nodes on right branch
    /// </summary>
    /// <param name="value"></param>
    /// <param name="indices"></param>
    [Theory]
    [InlineData(2, 0)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 3)]
    [InlineData(6, 4)]
    [InlineData(7, 5)]
    [InlineData(8, 6)]
    public void BreadthTraversalOrderRightTest(int value, int indices)
    {
      Tree.Classes.Node TreeRoot = new Tree.Classes.Node(2);
      TreeRoot.Right = new Tree.Classes.Node(3);
      TreeRoot.Right.Right = new Tree.Classes.Node(4);
      TreeRoot.Right.Right.Right = new Tree.Classes.Node(5);
      TreeRoot.Right.Right.Right.Right = new Tree.Classes.Node(6);
      TreeRoot.Right.Right.Right.Right.Right = new Tree.Classes.Node(7);
      TreeRoot.Right.Right.Right.Right.Right.Right = new Tree.Classes.Node(8);

      List<int> OutputList = BreadthFirst(TreeRoot);

      Assert.Equal(value, OutputList[indices]);
    }
  }
}
