using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("moM", true)]
        [InlineData("Dumbo", false)]
        [InlineData("jinglebells", false)]
        [InlineData("TestseT", true)]

        public void IsAPalindrome(string answer, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(answer);

            Assert.Equal(expected, actual);
        }
    }
}
