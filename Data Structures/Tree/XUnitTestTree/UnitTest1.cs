using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;
using System.Linq;

namespace XUnitTestTree
{
  /// <summary>
  /// tests for negative values in nodes
  /// </summary>
  /// <param name="value">expected value</param>
  /// <param name="index">index of element in list</param>
  public class UnitTest1
  {
    [Theory]
    [InlineData(2, 0)]
    [InlineData(3, 1)]
    [InlineData(5, 2)]
    [InlineData(6, 3)]
    [InlineData(4, 4)]
    [InlineData(7, 5)]
    [InlineData(8, 6)]
    public void PreOrderTest(int value, int index)
    {
      Node Root = new Node(2);
      Root.Left = new Node(3);
      Root.Right = new Node(4);
      Root.Left.Left = new Node(5);
      Root.Left.Right = new Node(6);
      Root.Right.Left = new Node(7);
      Root.Right.Right = new Node(8);

      List<int> Test = BinaryTree.PreOrder(Root);

      Assert.Equal(value, Test[index]);
    }
    /// <summary>
    /// if root is null, checks if list is empty
    /// </summary>
    [Fact]
    public void PreOrderNullTest()
    {
      Node Root = null;
      List<int> Test = BinaryTree.PreOrder(Root);
      Assert.Empty(Test);
    }
    /// <summary>
    /// tests for negative values in nodes
    /// </summary>
    /// <param name="value">expected value</param>
    /// <param name="index">index of element in list</param>
    [Theory]
    [InlineData(-2, 0)]
    [InlineData(-3, 1)]
    [InlineData(-5, 2)]
    [InlineData(-6, 3)]
    [InlineData(-4, 4)]
    [InlineData(-7, 5)]
    [InlineData(-8, 6)]
    public void PreOrderNegativTest(int value, int index)
    {
      Node Root = new Node(-2);
      Root.Left = new Node(-3);
      Root.Right = new Node(-4);
      Root.Left.Left = new Node(-5);
      Root.Left.Right = new Node(-6);
      Root.Right.Left = new Node(-7);
      Root.Right.Right = new Node(-8);

      List<int> Test = BinaryTree.PreOrder(Root);

      Assert.Equal(value, Test[index]);
    }
    /// <summary>
    /// inorder tests same struture as before
    /// </summary>
    /// <param name="value"></param>
    /// <param name="index"></param>
    [Theory]
    [InlineData(5, 0)]
    [InlineData(3, 1)]
    [InlineData(6, 2)]
    [InlineData(2, 3)]
    [InlineData(7, 4)]
    [InlineData(4, 5)]
    [InlineData(8, 6)]
    public void InOrderTest(int value, int index)
    {
      Node Root = new Node(2);
      Root.Left = new Node(3);
      Root.Right = new Node(4);
      Root.Left.Left = new Node(5);
      Root.Left.Right = new Node(6);
      Root.Right.Left = new Node(7);
      Root.Right.Right = new Node(8);

      List<int> Test = BinaryTree.InOrder(Root);

      Assert.Equal(value, Test[index]);
    }
    /// <summary>
    /// if root is null, checks if list is empty
    /// </summary>
    [Fact]
    public void InOrderNullTest()
    {
      Node Root = null;
      List<int> Test = BinaryTree.InOrder(Root);
      Assert.Empty(Test);
    }
    /// <summary>
    /// tests for negative values in nodes
    /// </summary>
    /// <param name="value">expected value</param>
    /// <param name="index">index of element in list</param>
    [Theory]
    [InlineData(-5, 0)]
    [InlineData(-3, 1)]
    [InlineData(-6, 2)]
    [InlineData(-2, 3)]
    [InlineData(-7, 4)]
    [InlineData(-4, 5)]
    [InlineData(-8, 6)]
    public void InOrderNegativTest(int value, int index)
    {
      Node Root = new Node(-2);
      Root.Left = new Node(-3);
      Root.Right = new Node(-4);
      Root.Left.Left = new Node(-5);
      Root.Left.Right = new Node(-6);
      Root.Right.Left = new Node(-7);
      Root.Right.Right = new Node(-8);

      List<int> Test = BinaryTree.InOrder(Root);

      Assert.Equal(value, Test[index]);
    }

    [Theory]
    [InlineData(5, 0)]
    [InlineData(6, 1)]
    [InlineData(3, 2)]
    [InlineData(7, 3)]
    [InlineData(8, 4)]
    [InlineData(4, 5)]
    [InlineData(2, 6)]
    public void PostOrderTest(int value, int index)
    {
      Node Root = new Node(2);
      Root.Left = new Node(3);
      Root.Right = new Node(4);
      Root.Left.Left = new Node(5);
      Root.Left.Right = new Node(6);
      Root.Right.Left = new Node(7);
      Root.Right.Right = new Node(8);

      List<int> Test = BinaryTree.PostOrder(Root);

      Assert.Equal(value, Test[index]);
    }
    /// <summary>
    /// if root is null, checks if list is empty
    /// </summary>
    [Fact]
    public void PostOrderNullTest()
    {
      Node Root = null;
      List<int> Test = BinaryTree.PostOrder(Root);
      Assert.Empty(Test);
    }
    /// <summary>
    /// tests for negative values in nodes
    /// </summary>
    /// <param name="value">expected value</param>
    /// <param name="index">index of element in list</param>
    [Theory]
    [InlineData(-5, 0)]
    [InlineData(-6, 1)]
    [InlineData(-3, 2)]
    [InlineData(-7, 3)]
    [InlineData(-8, 4)]
    [InlineData(-4, 5)]
    [InlineData(-2, 6)]
    public void PostOrderNegativTest(int value, int index)
    {
      Node Root = new Node(-2);
      Root.Left = new Node(-3);
      Root.Right = new Node(-4);
      Root.Left.Left = new Node(-5);
      Root.Left.Right = new Node(-6);
      Root.Right.Left = new Node(-7);
      Root.Right.Right = new Node(-8);

      List<int> Test = BinaryTree.PostOrder(Root);

      Assert.Equal(value, Test[index]);
    }
    /// <summary>
    /// search BST, should return node with 3
    /// </summary>
    [Fact]
    public void BSTSearch()
    {
      BinarySearchTree Test = new BinarySearchTree();
      Test.Add(5);
      Test.Add(4);
      Test.Add(3);
      Test.Add(2);

      Node FindTest = Test.Search(3);

      Assert.Equal(3, FindTest.Data);
    }
    /// <summary>
    /// left node of node that contains 3 should be 2
    /// </summary>
    [Fact]
    public void BSTSearchContinue()
    {
      BinarySearchTree Test = new BinarySearchTree();
      Test.Add(5);
      Test.Add(4);
      Test.Add(3);
      Test.Add(2);

      Node FindTest = Test.Search(3);

      Assert.Equal(2, FindTest.Left.Data);
    }
    /// <summary>
    /// returns null if nothing found
    /// </summary>
    [Fact]
    public void BSTSearchNoMatch()
    {
      BinarySearchTree Test = new BinarySearchTree();
      Test.Add(5);
      Test.Add(4);
      Test.Add(3);
      Test.Add(2);

      Node FindTest = Test.Search(7);

      Assert.Null(FindTest);
    }
    /// <summary>
    /// test that 5 is added
    /// </summary>
    [Fact]
    public void AddTest()
    {
      BinarySearchTree Test = new BinarySearchTree();
      Test.Add(5);
      Assert.Equal(5, Test.Root.Data);
    }
    /// <summary>
    /// tests that 4 is added to left node of 5
    /// </summary>
    [Fact]
    public void AddLessThanRootTest()
    {
      BinarySearchTree Test = new BinarySearchTree();
      Test.Add(5);
      Test.Add(4);
      Assert.Equal(4, Test.Root.Left.Data);
    }

    /// <summary>
    /// tests that 6 is added to right node of 5
    /// </summary>
    [Fact]
    public void AddGreaterThanRootTest()
    {
      BinarySearchTree Test = new BinarySearchTree();
      Test.Add(5);
      Test.Add(6);
      Assert.Equal(6, Test.Root.Right.Data);
    }
  }
}
