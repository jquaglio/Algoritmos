﻿using Algorithms.BitManipulation;
using Xunit;

namespace AlgorithmsTest.BitManipulation
{
    public class ConvertNumberToBinaryTest
    {
        [Fact]
        public void Convert_18_To_Binary()
        {
            sbyte number = 18;

            byte[] result = new ConvertNumberToBinary().FirstTry(number);

            Assert.Equal(new byte[] { 0, 0, 0, 1, 0, 0, 1, 0 }, result);
        }

        [Fact]
        public void Convert_123_To_Binary()
        {
            sbyte number = 123;

            byte[] result = new ConvertNumberToBinary().FirstTry(number);

            Assert.Equal(new byte[] { 0, 1, 1, 1, 1, 0, 1, 1 }, result);
        }
    }
}