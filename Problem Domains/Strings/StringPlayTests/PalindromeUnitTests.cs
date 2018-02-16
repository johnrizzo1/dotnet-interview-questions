using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringPlay;

namespace StringPlayTests
{
    [TestClass]
    public class PalindromeUnitTests
    {
        [TestMethod]
        public void TestIsPalindrome()
        {
            Assert.IsFalse(Palindrome.IsPalindrome("boo"));
            Assert.IsTrue(Palindrome.IsPalindrome(""));
            Assert.IsTrue(Palindrome.IsPalindrome("b"));
            Assert.IsTrue(Palindrome.IsPalindrome("boob"));
            Assert.IsTrue(Palindrome.IsPalindrome("bo-ob"));
        }
    }
}