using System;
using Xunit;
using System.Collections.Generic;
using Hashtables.Classes;
using TreeIntersectionChallenge;
using static TreeIntersectionChallenge.Program;

namespace XUnitTestTreeIntersection
{
    public class UnitTest1
    {
        /// <summary>
        /// an instantiated treenode object with no parameter will default
        /// with a value of zero (due to its int type restriction)
        /// thus, the return output list will only hold one value, which is zero
        /// </summary>
        [Fact]
        public void NullTreeTestCount()
        {
            TreeNode One = new TreeNode();
            TreeNode Two = new TreeNode();

            List<int> Output = TreeIntersection(One, Two);

            Assert.Single(Output);
        }
        /// <summary>
        /// an instantiated treenode object with no parameter will default
        /// with a value of zero (due to its int type restriction)
        /// thus, the return output list will only hold one value, which is zero
        /// </summary>
        [Fact]
        public void NullTreeTestValue()
        {
            TreeNode One = new TreeNode();
            TreeNode Two = new TreeNode();

            List<int> Output = TreeIntersection(One, Two);
            Assert.Equal(0, Output[0]);
        }

        /// <summary>
        /// there should be five sets of numbers that equals each other
        /// across the two trees
        /// </summary>
        [Fact]
        public void TreeTestListCount()
        {
            //Match
            TreeNode TreeOne = new TreeNode(5);
            TreeNode TreeTwo = new TreeNode(5);

            TreeOne.Left = new TreeNode(2);
            TreeTwo.Left = new TreeNode(3);

            //Match
            TreeOne.Right = new TreeNode(10);
            TreeTwo.Right = new TreeNode(10);

            //Match
            TreeOne.Left.Left = new TreeNode(16);
            TreeTwo.Left.Left = new TreeNode(16);

            //match
            TreeOne.Left.Right = new TreeNode(23);
            TreeTwo.Right.Left = new TreeNode(23);

            TreeTwo.Left.Right = new TreeNode(25);
            TreeOne.Right.Left = new TreeNode(18);

            TreeOne.Right.Right = new TreeNode(50);
            TreeTwo.Right.Right = new TreeNode(34);

            //Match
            TreeOne.Right.Right.Left = new TreeNode(56);
            TreeTwo.Right.Right.Right = new TreeNode(56);
            List<int> Output = TreeIntersection(TreeOne, TreeTwo);

            Assert.Equal(5, Output.Count);
        }
        [Theory]
        [InlineData(5, 0)]
        [InlineData(16, 1)]
        [InlineData(10, 2)]
        [InlineData(23, 3)]
        [InlineData(56, 4)]
        public void TreeTestListValue(int expected, int index)
        {
            //Match
            TreeNode TreeOne = new TreeNode(5);
            TreeNode TreeTwo = new TreeNode(5);

            TreeOne.Left = new TreeNode(2);
            TreeTwo.Left = new TreeNode(3);

            //Match
            TreeOne.Right = new TreeNode(10);
            TreeTwo.Right = new TreeNode(10);

            //Match
            TreeOne.Left.Left = new TreeNode(16);
            TreeTwo.Left.Left = new TreeNode(16);

            //match
            TreeOne.Left.Right = new TreeNode(23);
            TreeTwo.Right.Left = new TreeNode(23);

            TreeTwo.Left.Right = new TreeNode(25);
            TreeOne.Right.Left = new TreeNode(18);

            TreeOne.Right.Right = new TreeNode(50);
            TreeTwo.Right.Right = new TreeNode(34);

            //Match
            TreeOne.Right.Right.Left = new TreeNode(56);
            TreeTwo.Right.Right.Right = new TreeNode(56);
            List<int> Output = TreeIntersection(TreeOne, TreeTwo);

            Assert.Equal(expected, Output[index]);
        }
        /// <summary>
        /// Everything should match. Count should be 3 pairs.
        /// </summary>
        [Fact]
        public void AllMatchTest()
        {
            //Match
            TreeNode TreeOne = new TreeNode(5);
            TreeNode TreeTwo = new TreeNode(5);
            //Match
            TreeOne.Right = new TreeNode(10);
            TreeTwo.Right = new TreeNode(10);

            //Match
            TreeOne.Right.Left = new TreeNode(16);
            TreeTwo.Right.Left = new TreeNode(16);

            List<int> Output = TreeIntersection(TreeOne, TreeTwo);

            Assert.Equal(3, Output.Count);

        }
    }
}
