using System;
using Xunit;
using Tree.Classes;
using FizzBuzzTree;
using static FizzBuzzTree.Program;
using System.Collections.Generic;

namespace XUnitTestFizzBuzzTree
{
  public class UnitTest1
  {
    /// <summary>
    /// tests the correct FizzBuzz output for all 9 nodes
    /// based on input int values
    /// </summary>
    /// <param name="fizzbuzz">the output based on the int value</param>
    /// <param name="indices">index of list element</param>
    [Theory]
    [InlineData("2", 0)]
    [InlineData("Fizz", 1)]
    [InlineData("Fizz", 2)]
    [InlineData("8", 3)]
    [InlineData("FizzBuzz", 4)]
    [InlineData("4", 5)]
    [InlineData("7", 6)]
    [InlineData("FizzBuzz", 7)]
    [InlineData("Buzz", 8)]
    public void FizzBuzzTest(string fizzbuzz, int indices)
    {
      Node Root = new Node(2);
      Node Fizz = new Node(3);
      Node FizzSix = new Node(6);
      Node BuzzTen = new Node(10);
      Node FizzBuzz = new Node(15);
      Node FizzBuzz30 = new Node(30);
      Node Four = new Node(4);
      Node Eight = new Node(8);
      Node Seven = new Node(7);

      Root.Left = Fizz;
      Root.Right = BuzzTen;
      Root.Left.Left = FizzSix;
      Root.Left.Right = Four;
      Root.Left.Left.Left = Eight;
      Root.Left.Left.Right = FizzBuzz;
      Root.Left.Right.Left = Seven;
      Root.Left.Right.Right = FizzBuzz30;

      List<string> Test = FizzBuzzTree.Program.FizzBuzzTree(Root);

      Assert.Equal(fizzbuzz, Test[indices]);
    }
    /// <summary>
    /// null root should return no ouput
    /// evidence by empty list
    /// </summary>
    [Fact]
    public void FizzBuzzNullTest()
    {
      Node Root = null;
      List<string> Test = FizzBuzzTree.Program.FizzBuzzTree(Root);
      Assert.Empty(Test);
    }

    /// <summary>
    /// tests the correct FizzBuzz output for all 9 nodes
    /// for negative values
    /// </summary>
    /// <param name="fizzbuzz">the output based on the int value</param>
    /// <param name="indices">index of list element</param>
    [Theory]
    [InlineData("-2", 0)]
    [InlineData("Fizz", 1)]
    [InlineData("Fizz", 2)]
    [InlineData("-8", 3)]
    [InlineData("FizzBuzz", 4)]
    [InlineData("-4", 5)]
    [InlineData("-7", 6)]
    [InlineData("FizzBuzz", 7)]
    [InlineData("Buzz", 8)]
    public void FizzBuzzNegativeTest(string fizzbuzz, int indices)
    {
      Node Root = new Node(-2);
      Node Fizz = new Node(-3);
      Node FizzSix = new Node(-6);
      Node BuzzTen = new Node(-10);
      Node FizzBuzz = new Node(-15);
      Node FizzBuzz30 = new Node(-30);
      Node Four = new Node(-4);
      Node Eight = new Node(-8);
      Node Seven = new Node(-7);

      Root.Left = Fizz;
      Root.Right = BuzzTen;
      Root.Left.Left = FizzSix;
      Root.Left.Right = Four;
      Root.Left.Left.Left = Eight;
      Root.Left.Left.Right = FizzBuzz;
      Root.Left.Right.Left = Seven;
      Root.Left.Right.Right = FizzBuzz30;

      List<string> Test = FizzBuzzTree.Program.FizzBuzzTree(Root);

      Assert.Equal(fizzbuzz, Test[indices]);
    }
  }
}
