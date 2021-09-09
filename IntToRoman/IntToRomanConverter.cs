using System;
using System.Diagnostics;

namespace IntToRoman
{
    public class IntToRomanConverter
    {
        public static string ToRoman(int v)
        {
            return v switch
            {
                0 => string.Empty,
                _ => ToRoman(v-1) + "I"
            };
        }
    }
}
