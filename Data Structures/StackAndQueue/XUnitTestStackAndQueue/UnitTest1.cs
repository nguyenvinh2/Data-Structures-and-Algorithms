using System;
using Xunit;
using StackAndQueue;
using StackAndQueue.Classes;

namespace XUnitTestStackAndQueue
{
  public class UnitTest1
  {
    /// <summary>
    /// tests that a node can be added to the Stack
    /// </summary>
    [Fact]
    public void StackPeekTest()
    {
      Node TestNode = new Node("Aaah");
      Stack TestStack = new Stack(TestNode);
      Assert.Equal(TestNode, TestStack.Peek());
    }

    /// <summary>
    /// Peek test for Null condition
    /// </summary>
    [Fact]
    public void StackPeekNullTest()
    {
      Stack TestStack = new Stack(null);
      Assert.Null(TestStack.Peek());
    }
    /// <summary>
    /// tests that after adding a node to top stack, peeking
    /// will return the top node
    /// </summary>
    [Fact]
    public void StackPushTest()
    {
      Node TestNode = new Node("Baah");
      Stack TestStack = new Stack(new Node("Aaah"));
      TestStack.Push(TestNode);
      Assert.Equal(TestNode, TestStack.Peek());
    }
    /// <summary>
    /// removing the only node from a stack should return null
    /// </summary>
    [Fact]
    public void StackPopTest()
    {
      Node TestNode = new Node("Aaah");
      Stack TestStack = new Stack(TestNode);
      TestStack.Pop();
      Assert.Null(TestStack.Peek());
    }

  }
}
