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
        public void ToRoman_Negative_Throw_ArgumentException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => IntToRomanConverter.ToRoman(-1));
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        public void ToRoman_OneToThree_Return_Is(int arabic, string roman)
        {
            var res = IntToRomanConverter.ToRoman(arabic);
            Assert.Equal(roman, res);
        }

        [Fact]
        public void ToRoman_Five_Return_V()
        {
            var res = IntToRomanConverter.ToRoman(5);
            Assert.Equal("V", res);
        }

        [Fact]
        public void ToRoman_1678_Return_MDCLXXVIII()
        {
            var res = IntToRomanConverter.ToRoman(1678);
            Assert.Equal("MDCLXXVIII", res);
        }

    }
}
