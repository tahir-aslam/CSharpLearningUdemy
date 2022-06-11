using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringEntensions
    {
        public static string Shorten(this string str, int noOfWords)
        {
            if (noOfWords < 0)
                throw new ArgumentOutOfRangeException("no of words should not be less than zero");

            var words = str.Split(' ');

            if (words.Length < noOfWords)
                return str;

            return string.Join(" ", words.Take(noOfWords));
        }
    }
}
