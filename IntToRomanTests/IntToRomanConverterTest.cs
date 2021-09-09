using IntToRoman;
using System;
using Xunit;

namespace IntToRomanTests
{
    public class IntToRomanConverterTest
    {
        [Fact]
        public void ToRoman_Zero_Return_EmptyString()
        {
            var res = IntToRomanConverter.ToRoman(0);
            Assert.Empty(res);
        }

        [Fact]
        public void ToRoman_One_Return_I()
        {
            var res = IntToRomanConverter.ToRoman(1);
            Assert.Equal("I", res);
        }

    }
}
