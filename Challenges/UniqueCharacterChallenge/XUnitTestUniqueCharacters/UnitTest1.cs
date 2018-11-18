using System;
using Xunit;
using Hashtables.Classes;
using static UniqueCharacterChallenge.Program;

namespace XUnitTestUniqueCharacters
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests for various strings for false
        /// </summary>
        /// <param name="input">string </param>
        /// <param name="output">xpected bool false</param>
        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog")]
        [InlineData("hey me and you")]
        [InlineData("krazy kwanza")]
        [InlineData("hgshdkghskjgh")]
        [InlineData("Donald the duck")]
        public void VariousStringTestFalse(string input)
        {
            Assert.False(UniqueCharacter(input));
        }

        /// <summary>
        /// Tests for various strings for true result
        /// </summary>
        /// <param name="input">string </param>
        /// <param name="output">xpected bool false</param>
        [Theory]
        [InlineData("The quick brown")]
        [InlineData("I love Cats")]
        [InlineData("krazy")]
        [InlineData("hgs")]
        [InlineData("the duck")]
        public void VariousStringTestTrue(string input)
        {
            Assert.True(UniqueCharacter(input));
        }


        /// <summary>
        /// Tests for various punctution characters for true result
        /// </summary>
        /// <param name="input">string </param>
        /// <param name="output">xpected bool false</param>
        [Theory]
        [InlineData("!?#")]
        [InlineData("@#$%^")]
        public void VariousStringTestPunctation(string input)
        {
            Assert.True(UniqueCharacter(input));
        }

        /// <summary>
        /// if string is null, technically it does have unique characters
        /// </summary>
        [Fact]
        public void NullTest()
        {
            string input = null;
            Assert.True(UniqueCharacter(input));
        }
    }
}
