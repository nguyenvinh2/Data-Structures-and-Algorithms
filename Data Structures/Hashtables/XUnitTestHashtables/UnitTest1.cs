using System;
using Xunit;
using Hashtables.Classes;

namespace XUnitTestHashtables
{
  public class UnitTest1
  {
    /// <summary>
    /// Tests an insertion into the array
    /// checks to see if hastable will return value
    /// to key
    /// </summary>
    [Fact]
    public void InsertTest()
    {
      Hashtable TestHash = new Hashtable();
      TestHash.Add("Test2Value", "Passes");

      Assert.Equal("Passes", TestHash.Find("Test2Value"));
    }
    /// <summary>
    /// tests that the array contains the new index
    /// </summary>
    [Fact]
    public void ContainsTest()
    {
      Hashtable TestHash = new Hashtable();
      TestHash.Add("Test2Value", "Passes");

      Assert.True(TestHash.Contains("Test2Value"));
    }

    /// <summary>
    /// tests that the array does not contains the new index
    /// </summary>
    [Fact]
    public void DoesNotContainsTest()
    {
      Hashtable TestHash = new Hashtable();
      TestHash.Add("Test2Value", "Passes");

      Assert.False(TestHash.Contains("TestValue"));
    }

    /// <summary>
    /// tests that both keys are at the same index
    /// </summary>
    [Fact]
    public void CollisionTestOne()
    {
      Hashtable TestHash = new Hashtable();
      TestHash.Add("a", "Clone");
      TestHash.Add("abc", "clone 2");

      Assert.Equal(Hashtable.GetHash("b"), Hashtable.GetHash("abc"));
    }

    /// <summary>
    /// tests that both keys do not return the same values due to collision
    /// </summary>
    [Fact]
    public void CollisionTestTwo()
    {
      Hashtable TestHash = new Hashtable();
      TestHash.Add("a", "Clone");
      TestHash.Add("abc", "clone 2");

      Assert.NotEqual(TestHash.Find("a"), TestHash.Find("abc"));
    }


    /// <summary>
    /// tests the second added key with same index will return correct value
    /// </summary>
    [Fact]
    public void CollisionTestThree()
    {
      Hashtable TestHash = new Hashtable();
      TestHash.Add("a", "Clone");
      TestHash.Add("abc", "clone 2");

      Assert.Equal("clone 2", TestHash.Find("abc"));
    }
  }
}
