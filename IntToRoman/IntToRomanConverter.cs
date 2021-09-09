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
                0 => string.Empty,
                _ when num < 0 => throw new ArgumentOutOfRangeException(nameof(num), "should be positive number"),
                _ when num >= 5 => "V" + ToRoman(num - 5),
                _ => ToRoman(num-1) + "I"
            };
        }
    }
}
