using System;
using Xunit;
using static RepeatedWordChallenge.Program;

namespace XUnitTestRepeatedWords
{
    public class UnitTest1
    {
        /// <summary>
        /// test different phrases, punctuations ignored
        /// ignores case sensitivity
        /// </summary>
        /// <param name="input">sentence</param>
        /// <param name="answer">returned word</param>
        [Theory]
        [InlineData("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...", "it")]
        [InlineData("Once upon a time, there was a brave princess who...", "a")]
        [InlineData("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...", "summer")]
        public void RandomStringTest(string input, string answer)
        {
            string test = RepeatedWord(input);
            Assert.Equal(answer, test);
        }
        /// <summary>
        /// if string is empty return null
        /// </summary>
        [Fact]
        public void NullTest()
        {
            string input = null;
            string test = RepeatedWord(input);
            Assert.Null(test);
        }
        /// <summary>
        /// test numbers as strings
        /// </summary>
        [Fact]
        public void NumbersTest()
        {
            string input = "1 2 3 2";
            string test = RepeatedWord(input);
            Assert.Equal("2",test);
        }
    }
}
