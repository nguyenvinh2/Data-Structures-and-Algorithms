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
    /// <summary>
    /// tests popping a null stack
    /// </summary>
    [Fact]
    public void StackPopNullTest()
    {
      Stack TestStack = new Stack(null);
      TestStack.Pop();
      Assert.Null(TestStack.Peek());
    }
    /// <summary>
    /// tests that peeking will return the correct node
    /// </summary>
    [Fact]
    public void QueuePeekTest()
    {
      Node TestNode = new Node("Aaah");
      Queue TestQueue = new Queue(TestNode);
      Assert.Equal(TestNode, TestQueue.Peek());
    }
    /// <summary>
    /// null peek test for queue
    /// </summary>
    [Fact]
    public void QueuePeekNullTest()
    {
      Queue TestQueue = new Queue(null);
      Assert.Null(TestQueue.Peek());
    }
    /// <summary>
    /// tests enqueing works, the rear node should be the node enqueue
    /// </summary>
    [Fact]
    public void QueueEnQueueTest()
    {
      Node TestNode = new Node("Aaah");
      Queue TestQueue = new Queue(new Node("Reek"));
      TestQueue.Enqueue(TestNode);
      Assert.Equal(TestNode, TestQueue.Rear);
    }
    /// <summary>
    /// test dequeuing works, front node should be the rear node in this two node stack after dequeing
    /// </summary>
    [Fact]
    public void QueueDeQueueTest()
    {
      Node TestNode = new Node("Aaah");
      Queue TestQueue = new Queue(new Node("Reek"));
      TestQueue.Enqueue(TestNode);
      TestQueue.Dequeue();
      Assert.Equal(TestNode, TestQueue.Peek());
    }
    /// <summary>
    /// tests dequeuing null
    /// </summary>
    [Fact]
    public void QueueDeQueueNullTest()
    {
      Queue TestQueue = new Queue(null);
      TestQueue.Dequeue();
      Assert.Null(TestQueue.Peek());
    }
  }
}
