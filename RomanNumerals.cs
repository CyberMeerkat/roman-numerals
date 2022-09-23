using System;
using System.Collections.Generic;
using System.Linq;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        var romanNumber = "";
        foreach (var item in RomanDict().Reverse())
        {
            if (value <= 0) break;
            while (value >= item.Key)
            {
                romanNumber += item.Value;
                value -= item.Key;
            }
        }
        return romanNumber;
    }
    public static Dictionary<int, string> RomanDict() =>
        new Dictionary<int, string>(){
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"}, 
            {900, "CM"},
            {1000, "M"}
         };   
}