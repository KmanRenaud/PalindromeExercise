using PalindromeExercise;
using System;
using Xunit;



namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racekar", false)]
        [InlineData("n0On", false)]
        [InlineData("bulud", false)]
        [InlineData("kayak", true)]
        [InlineData("rotator", true)]
        public void TestIfPalindrome(string pal, bool expected)
        {
            //Arrange
            var isPal = new WordSmith();
            //Act
            var actual = isPal.IsAPalindrome(pal);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
