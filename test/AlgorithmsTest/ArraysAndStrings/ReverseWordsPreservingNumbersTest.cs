﻿using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ReverseWordsPreservingNumbersTest
    {
        [Fact]
        public void FirstTry_Reverse_Words()
        {
            string myEntireString = "The quick, bro567wn 125 foxes jump over the lazy, fuzzy, hounds!";

            string returnedValue = new ReverseWordsPreservingNumbers().FirstTry(myEntireString);

            Assert.Equal("ehT ,kciuq orb567nw 125 sexof pmuj revo eht ,yzal ,yzzuf !sdnuoh", returnedValue);
        }

        [Fact]
        public void FirstTry_Reverse_Words_In_Hello_World_String()
        {
            string myEntireString = "Hello W0rld!";

            string returnedValue = new ReverseWordsPreservingNumbers().FirstTry(myEntireString);

            Assert.Equal("olleH W0!dlr", returnedValue);
        }
    }
}