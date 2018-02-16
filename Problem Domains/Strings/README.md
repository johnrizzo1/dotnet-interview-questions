# Strings

## Problems

### Palindrome

An acceptible solution.

```c#
public static class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        for (int i=0; i<word.Length; i++)
        {
            if ( word[i] != word[word.Length-i-1] ) { return false; }
        }

        return true;
    }
}
```