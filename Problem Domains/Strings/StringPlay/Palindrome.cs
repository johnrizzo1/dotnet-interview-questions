using System;

namespace StringPlay
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("message", nameof(word));
            }

            throw new System.NotImplementedException("Waiting to be implemented.");
        }
    }
}