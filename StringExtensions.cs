using System;
using System.Linq;

namespace StringExtensionsDemo
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var cleaned = input.Replace(" ", "").ToLower();
            var reversed = new string(cleaned.ToCharArray().Reverse().ToArray());
            return cleaned == reversed;
        }

        public static string ReverseString(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        public static int WordCount(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}