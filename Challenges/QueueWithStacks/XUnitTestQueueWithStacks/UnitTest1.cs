using System;
using Xunit;
using QueueWithStacks.Classes;
using StackAndQueue.Classes;
using Queue = QueueWithStacks.Classes.Queue;

namespace XUnitTestQueueWithStacks
{
  public class UnitTest1
  {
    /// <summary>
    /// peek at the queue should return the first node added
    /// </summary>
    [Fact]
    public void FIFOTestEnqueue()
    {
      Node One = new Node("Papa");
      Node Two = new Node("Mama");
      Queue TestQueue = new Queue();
      TestQueue.Enqueue(One);
      TestQueue.Enqueue(Two);
      Assert.Equal(One, TestQueue.Peek());
    }
    /// <summary>
    /// Removing the front node should reveal the second node after peeking
    /// </summary>
    [Fact]
    public void FIFOTestDequeue()
    {
      Node One = new Node("Papa");
      Node Two = new Node("Mama");
      Queue TestQueue = new Queue();
      TestQueue.Enqueue(One);
      TestQueue.Enqueue(Two);
      TestQueue.Dequeue();
      Assert.Equal(Two, TestQueue.Peek());
    }
    /// <summary>
    /// Inserting null should not affect queue sequence 
    /// </summary>
    [Fact]
    public void FIFOTestNull()
    {
      Node One = new Node("Papa");
      Node Two = new Node("Mama");
      Queue TestQueue = new Queue();
      TestQueue.Enqueue(One);
      TestQueue.Enqueue(null);
      TestQueue.Enqueue(Two);
      TestQueue.Dequeue();
      Assert.Equal(Two, TestQueue.Peek());
    }
    /// <summary>
    /// should be able to count correct number of nodes in queue
    /// and null should not count, in this case 2 node is added
    /// to queue
    /// </summary>
    [Fact]
    public void SizeTest()
    {
      Node One = new Node("Papa");
      Node Two = new Node("Mama");
      Queue TestQueue = new Queue();
      TestQueue.Enqueue(One);
      TestQueue.Enqueue(null);
      TestQueue.Enqueue(Two);
      Assert.Equal(2, TestQueue.GetSize());
    }
  }
}
