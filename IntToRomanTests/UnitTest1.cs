using IntToRoman;
using System;
using Xunit;

namespace IntToRomanTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Class1.ToRoman(0);
            Assert.Empty(res);
        }
    }
}
