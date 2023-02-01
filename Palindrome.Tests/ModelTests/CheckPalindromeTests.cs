using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests 
{
  [TestClass]
  public class CheckPalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_IsString_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("mom"));
    }

    [TestMethod]
    public void IsPalindrome_IsArray_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("mom"));
    }

    [TestMethod]
    public void IsPalindrome_IsNewArrayAnArray_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("mom"));
    }

    [TestMethod]
    public void IsPalindrome_IsReversedArrayAnArray_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("mom"));
    }

    [TestMethod]
    public void IsPalindrome_IsPalindrome_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("a toyota"));
    }
    
    [TestMethod]
    public void IsPalindrome_AllLowerNoSpace_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("A tOyOtA"));

    }

    [TestMethod]

    public void IsPalindrome_NumberInputs_True()
    {
      CheckPalindrome testCheckPalindrome = new CheckPalindrome();
      Assert.AreEqual(true, testCheckPalindrome.IsPalindrome("1001"));
    }
  }
}