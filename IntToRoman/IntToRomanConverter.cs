using System;
using System.Diagnostics;

namespace IntToRoman
{
    public class IntToRomanConverter
    {
        public static string ToRoman(int num)
        {
            return num switch
            {
                _ when num >= 1000 => "M" + ToRoman(num - 1000),
                _ when num >= 500 => "D" + ToRoman(num - 500),
                _ when num >= 100 => "C" + ToRoman(num - 100),
                _ when num >= 50 => "L" + ToRoman(num - 50),
                _ when num >= 10 => "X" + ToRoman(num - 10),
                _ when num == 9 => "IX" + ToRoman(num - 9),
                _ when num >= 5 => "V" + ToRoman(num - 5),
                _ when num == 4 => "IV" + ToRoman(num - 4),
                _ when num >= 1 => "I" + ToRoman(num - 1),
                0 => string.Empty,
                _ => throw new ArgumentOutOfRangeException(nameof(num), "should be positive number"),
            };
        }
    }
}
