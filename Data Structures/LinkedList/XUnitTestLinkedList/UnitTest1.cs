using System;
using Xunit;
using LinkedList;
using static LinkedList.Program;


namespace XUnitTestLinkedList
{
  public class UnitTest1
  {
    /// <summary>
    /// Three tests search for 1st specific value in List
    /// Expected true
    /// </summary>
    /// <param name="input"></param>
    [Fact]
    public void IncludesTestOne()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      Assert.True(TestList.Includes("Hello"));
    }
    /// <summary>
    /// Three tests search for 2nd specific value in List
    /// Expect true
    /// </summary>
    [Fact]
    public void IncludesTestTwo()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      Assert.True(TestList.Includes("Crazy"));
    }
    /// <summary>
    /// Three tests search for unmatch specific value in List
    /// Expect false
    /// </summary>
    [Fact]
    public void IncludesTestThree()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      Assert.False(TestList.Includes("Creazy"));
    }
    /// <summary>
    /// Test if value "Creazy" is actually added
    /// </summary>
    [Fact]
    public void AddAfterTestOne()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      TestList.AddAfter(new Node("Creazy"), new Node("World"));
      Assert.True(TestList.Includes("Creazy"));
    }
    /// <summary>
    /// Determines it corrects position
    /// Creazy is added after Crazy (2nd position)
    /// so should return 3
    /// </summary>
    [Fact]
    public void AddAfterTestTwo()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      TestList.AddAfter(new Node("Creazy"), new Node("Crazy"));
      int count = 0;
      TestList.Current = TestList.Head;
      while (TestList.Current != null)
      {
        count++;
        if (TestList.Current.Data == new Node("Creazy").Data)
        {
          break;
        }
        TestList.Current = TestList.Current.Next;
      }
      Assert.Equal(3, count);
    }
    /// <summary>
    /// will not add if node to be added after is not found
    /// </summary>
    [Fact]
    public void AddAfterTestThree()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      TestList.AddAfter(new Node("Creazy"), new Node("Werld"));
      Assert.False(TestList.Includes("Creazy"));
    }

    [Fact]
    public void AddBeforeTestOne()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      TestList.AddBefore(new Node("Creanzy"), new Node("World"));
      Assert.True(TestList.Includes("Creanzy"));
    }
    /// Determines it corrects position
    /// Creazy is added before Crazy (2nd position)
    /// so should take Crazy's position and return 2
    [Fact]
    public void AddBeforeTestTwo()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      TestList.AddBefore(new Node("Creanzy"), new Node("Crazy"));
      int count = 0;
      TestList.Current = TestList.Head;
      while (TestList.Current != null)
      {
        count++;
        if (TestList.Current.Data == new Node("Creanzy").Data)
        {
          break;
        }
        TestList.Current = TestList.Current.Next;
      }
      Assert.Equal(2, count);
    }
    [Fact]
    public void AddBeforeTestThree()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      TestList.AddAfter(new Node("Creazy"), new Node("Werld"));
      Assert.False(TestList.Includes("Creazy"));
    }
    /// <summary>
    /// Test data is being added
    /// </summary>
    [Fact]
    public void AddtoHeadTestOne()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      Assert.True(TestList.Includes("World"));
    }
    /// <summary>
    /// "World" is last in operation so should be added to the head
    /// return should be 1 for 1st position
    /// </summary>
    [Fact]
    public void AddToHeadTestTwo()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node("World"));
      int count = 0;
      TestList.Current = TestList.Head;
      while (TestList.Current != null)
      {
        count++;
        if (TestList.Current.Data == new Node("World").Data)
        {
          break;
        }
        TestList.Current = TestList.Current.Next;
      }
      Assert.Equal(1, count);
    }
    /// <summary>
    /// Checks that null data can be added
    /// </summary>
    [Fact]
    public void AddtoHeadTestThree()
    {
      LinkList TestList = new LinkList();
      TestList.AddToHead(new Node("Hello"));
      TestList.AddToHead(new Node("Crazy"));
      TestList.AddToHead(new Node(null));
      Assert.True(TestList.Includes(null));
    }
    /// <summary>
    /// Tests that append can add a value
    /// </summary>
    [Fact]
    public void AppendTestOne()
    {
      LinkList TestList = new LinkList();
      TestList.Append(new Node("Hello"));
      TestList.Append(new Node("Crazy"));
      TestList.Append(new Node("World"));
      Assert.True(TestList.Includes("World"));
    }
    /// <summary>
    /// World is added last in operation
    /// should should return 3 for 3rd position
    /// </summary>
    [Fact]
    public void AppendTestTwo()
    {
      LinkList TestList = new LinkList();
      TestList.Append(new Node("Hello"));
      TestList.Append(new Node("Crazy"));
      TestList.Append(new Node("World"));
      int count = 0;
      TestList.Current = TestList.Head;
      while (TestList.Current != null)
      {
        count++;
        if (TestList.Current.Data == new Node("World").Data)
        {
          break;
        }
        TestList.Current = TestList.Current.Next;
      }
      Assert.Equal(3, count);
    }
    /// <summary>
    /// checks if can add null
    /// </summary>
    [Fact]
    public void AppendTestThree()
    {
      LinkList TestList = new LinkList();
      TestList.Append(new Node("Hello"));
      TestList.Append(new Node("Crazy"));
      TestList.Append(new Node(null));
      Assert.True(TestList.Includes(null));
    }
  }
}
