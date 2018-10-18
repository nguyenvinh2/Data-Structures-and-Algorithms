using System;
using Xunit;
using LinkedList;
using llMerge;
using static llMerge.Program;

namespace XUnitTestllMerge
{
  /// <summary>
  /// Tests that if both input LL have null values for its head node,
  /// the return will be a link list with null value as well
  /// </summary>
  public class UnitTest1
  {
    [Fact]
    public void BothNullInputTests()
    {
      LinkList One = new LinkList();
      LinkList Two = new LinkList();

      LinkList Three = Merge(One, Two);

      Assert.Null(Three.Head);
    }
    /// <summary>
    /// tests that if one LL is empty, the return link list
    /// will simply be the other non empty link list
    /// </summary>
    [Fact]
    public void OneNullInputTests()
    {
      LinkList One = new LinkList();
      LinkList Two = new LinkList();

      One.Append(new Node("A"));
      One.Append(new Node("B"));
      One.Append(new Node("C"));

      LinkList Three = Merge(One, Two);

      Assert.Equal(One, Three);
    }
    /// <summary>
    /// checks to see if merge LL has alternating properties
    /// as we travel through the merge LL in sequence, its return data
    /// should alternate
    /// </summary>
    /// <param name="expected">what the data should be</param>
    /// <param name="input"> the next node in the sequence</param>
    [Theory]
    [InlineData("A", 0)]
    [InlineData("One", 1)]
    [InlineData("B", 2)]
    [InlineData("Two", 3)]
    [InlineData("C", 4)]
    [InlineData("D", 5)]
    public void ZipTest(object expected, int input)
    {
      LinkList One = new LinkList();
      LinkList Two = new LinkList();

      One.Append(new Node("A"));
      One.Append(new Node("B"));
      One.Append(new Node("C"));
      One.Append(new Node("D"));

      Two.Append(new Node("One"));
      Two.Append(new Node("Two"));

      LinkList Three = Merge(One, Two);
      Three.Current = Three.Head;
      for (int i = 0; i < input; i++)
      {
        Three.Current = Three.Current.Next;
      }
      Assert.Equal(expected, Three.Current.Data);
    }
  }
}
