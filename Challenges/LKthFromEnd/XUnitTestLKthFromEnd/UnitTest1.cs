using System;
using Xunit;
using LinkedList;
using LKthFromEnd;
using static LKthFromEnd.Program;

namespace XUnitTestLKthFromEnd
{
  public class UnitTest1
  {
    /// <summary>
    /// checks to see if the proper node is returned from a dummy generated
    /// Link List with random values added in
    /// </summary>
    /// <param name="nodeValue">value at the node, in this case a string</param>
    /// <param name="input">kth element from the end</param>
    [Theory]
    [InlineData("Something", 6)]
    [InlineData("Has", 5)]
    [InlineData("Gone", 4)]
    [InlineData("Wrong", 3)]
    [InlineData("Charlie", 2)]
    [InlineData("Dan", 1)]
    [InlineData("Stan", 0)]
    public void ReturnRightNode(string nodeValue, int input)
    {
      LinkList InputList = new LinkList();
      InputList.Append(new Node("Something"));
      InputList.Append(new Node("Has"));
      InputList.Append(new Node("Gone"));
      InputList.Append(new Node("Wrong"));
      InputList.Append(new Node("Charlie"));
      InputList.Append(new Node("Dan"));
      InputList.Append(new Node("Stan"));
      Assert.Equal(nodeValue, KthSearch(input, InputList).Data);
    }
    /// <summary>
    /// If k specified is greater than the length,
    /// will return null
    /// </summary>
    [Fact]
    public void ReturnOutOfRange()
    {
      LinkList InputList = new LinkList();
      InputList.Append(new Node("Something"));
      InputList.Append(new Node("Has"));
      InputList.Append(new Node("Gone"));
      InputList.Append(new Node("Wrong"));
      InputList.Append(new Node("Charlie"));
      InputList.Append(new Node("Dan"));
      InputList.Append(new Node("Stan"));
      Assert.Null(KthSearch(8, InputList));
    }
    /// <summary>
    /// Will return null if negative k is specified
    /// </summary>
    [Fact]
    public void ReturnNegativeInput()
    {
      LinkList InputList = new LinkList();
      InputList.Append(new Node("Something"));
      InputList.Append(new Node("Has"));
      InputList.Append(new Node("Gone"));
      InputList.Append(new Node("Wrong"));
      InputList.Append(new Node("Charlie"));
      InputList.Append(new Node("Dan"));
      InputList.Append(new Node("Stan"));
      Assert.Null(KthSearch(-4, InputList));
    }
  }
}
