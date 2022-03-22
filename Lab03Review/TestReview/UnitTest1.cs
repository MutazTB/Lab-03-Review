using System;
using Xunit;
using Lab03Review;

namespace SystemIOTwoUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("1 a 3", 3)]
        [InlineData("1 2", 0)]
        [InlineData("1 2 3 4", 6)]
        [InlineData("-1 2 3", -6)]
        [InlineData("-1 2 0", 0)]
        public void GetProductTests(string input, int expected)
        {
            int actual = Program.GetProduct(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 4 }, 4)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 1)]        
        public void getPopularElementTests(int[] arr, int expected)
        {
            int actual = Program.getPopularElement(arr);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }, 555)]
        [InlineData(new int[] { -5, -1, -2 }, -1)]
        [InlineData(new int[] { -5, -100, -1, 2 }, 2)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        public void maxTests(int[] arr, int expected)
        {
            int actual = Program.max(arr);            
            Assert.Equal(expected, actual);
        }        
    }
}