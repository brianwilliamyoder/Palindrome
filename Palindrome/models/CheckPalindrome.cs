using System;

namespace Palindrome
{
  public class CheckPalindrome
  {
    public bool IsPalindrome (string word)

    {
      string allLowerNoCaps = word.ToLower().Replace(" ", "");
      char[] wordArray = allLowerNoCaps.ToCharArray();
      Array.Reverse(wordArray);
      string reversedWord = string.Join("", wordArray);
      return allLowerNoCaps == reversedWord;
     }
  }
}
