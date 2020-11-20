using System;

namespace Revers_String
{
    public static class ReversAllString
    {
        public static string ReverseString(this string s)
        {
            if (s == null)
                throw new ArgumentNullException("String cannot be null.");

            string[] words = s.Split();
            Array.Reverse(words);

            return String.Join(" ", words);
        }
    }
}
