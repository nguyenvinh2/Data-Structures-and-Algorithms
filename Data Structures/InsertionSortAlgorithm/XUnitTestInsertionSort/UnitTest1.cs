using System;
using Xunit;
using static InsertionSortAlgorithm.Program;

namespace XUnitTestInsertionSort
{
    public class UnitTest1
    {
        /// <summary>
        /// tests to see if entire array is correctly sorted
        /// </summary>
        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 1)]
        [InlineData(5, 2)]
        [InlineData(6, 3)]
        [InlineData(7, 4)]
        [InlineData(7, 5)]
        [InlineData(8, 6)]
        [InlineData(12, 7)]
        [InlineData(13, 8)]
        [InlineData(43, 9)]
        public void SortTest(int expected, int index)
        {
            int[] testInputArray = new int[10]{ 6,7,3,7,5,12,43,8,4,13};

            int[] testOutput = InsertionSort(testInputArray);

            Assert.Equal(expected, testOutput[index]);
        }

        /// <summary>
        /// tests to see if entire array is correctly sorted with negative values
        /// </summary>
        [Theory]
        [InlineData(-43, 0)]
        [InlineData(-13, 1)]
        [InlineData(-12, 2)]
        [InlineData(-8, 3)]
        [InlineData(-7, 4)]
        [InlineData(-7, 5)]
        [InlineData(-6, 6)]
        [InlineData(-5, 7)]
        [InlineData(-4, 8)]
        [InlineData(-3, 9)]
        public void NegativeSortTest(int expected, int index)
        {
            int[] testInputArray = new int[10] { -6, -7, -3, -7, -5, -12, -43, -8, -4, -13 };

            int[] testOutput = InsertionSort(testInputArray);

            Assert.Equal(expected, testOutput[index]);
        }

        /// <summary>
        /// tests to see if entire array is correctly sort with already sorted values
        /// </summary>
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        [InlineData(6, 5)]
        [InlineData(7, 6)]
        [InlineData(8, 7)]
        [InlineData(9, 8)]
        [InlineData(10, 9)]
        public void AlreadySortTest(int expected, int index)
        {
            int[] testInputArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] testOutput = InsertionSort(testInputArray);

            Assert.Equal(expected, testOutput[index]);
        }
        /// <summary>
        /// test if array is null
        /// </summary>
        [Fact]
        public void NullTest()
        {
            int[] testInputArray = null;
            int[] testOutput = InsertionSort(testInputArray);

            Assert.Null(testOutput);
        }
    }
}
