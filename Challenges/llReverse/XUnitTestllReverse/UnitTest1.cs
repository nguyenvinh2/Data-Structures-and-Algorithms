using System;
using Xunit;
using llReverse;
using static llReverse.Program;
using LinkedList;


namespace XUnitTestllReverse
{
  public class UnitTest1
  {
    /// <summary>
    /// this tests for the condition of an empty link list
    /// </summary>
    [Fact]
    public void NullTest()
    {
      LinkList TestInput = new LinkList();

      LinkList TestOutput = LLReverse(TestInput);

      Assert.Null(TestOutput.Head);
    }
    /// <summary>
    /// Tests that by reversing the link lists, it will have the same number
    /// of nodes as the original
    /// </summary>
    [Fact]
    public void SameNumberOfNodesTest()
    {
      string[] TestValues = new string[] { "Aaaah", "Baaah", "Caaah", "Daaah", "Eaaah", "Faaah" };
      LinkList Input = new LinkList();
      for (int i = 0; i < TestValues.Length; i++)
      {
        Input.Append(new Node(TestValues.Length - 1 - i));
      }
      LinkList Temp = Input;

      LinkList Output = LLReverse(Temp);

      int inputCount = 0;
      int outputCount = 0;

      Input.Current = Input.Head;
      while (Input.Current != null)
      {
        inputCount++;
        Input.Current = Input.Current.Next;
      }
      Output.Current = Output.Head;
      while (Output.Current != null)
      {
        outputCount++;
        Output.Current = Output.Current.Next;
      }

      Assert.Equal(inputCount, outputCount);
    }
    /// <summary>
    /// tests that the string values of the Output string data are in reverse of what was added
    /// </summary>
    [Theory]
    [InlineData("Eaaah", 0)]
    [InlineData("Daaah", 1)]
    [InlineData("Caaah", 2)]
    [InlineData("Baaah", 3)]
    [InlineData("Aaaah", 4)]
    public void ReverseTest(string expected, int input)
    {
      string[] TestValues = new string[] { "Aaaah", "Baaah", "Caaah", "Daaah", "Eaaah"};
      LinkList Input = new LinkList();
      for (int i = 0; i < TestValues.Length; i++)
      {
        Input.Append(new Node(TestValues[i]));
      }
      LinkList Output = LLReverse(Input);
      string[] OutValues = new string[5];
      Output.Current = Output.Head;
      int count = 0;
      while (Output.Current != null)
      {
        OutValues[count] = System.Convert.ToString(Output.Current.Data);
        Output.Current = Output.Current.Next;
        count++;
      }
      Assert.Equal(expected, OutValues[input]);
    }
  }
}
