
using System;

namespace Palindrome {

  public class PalindromeChecker
  {
    public bool isAPalindrome(string userWord)
    {
      // for (int os = 0; os < userWord.Length/2; os++)
      // {
      //   if (userWord[0 + os] != userWord[userWord.Length -1 - os])
      //   {
      //     return false;
      //   }
      // }
      //
      // return true;
      for (int i = 0, j = userWord.Length -1; i < j; i++, j--) {
        if (userWord[i] != userWord[j])
        {
          return false;
        }
      }
      return true;
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      string userWord = Console.ReadLine();

    PalindromeChecker pal = new PalindromeChecker();
    bool isPal = pal.isAPalindrome(userWord);
    Console.WriteLine(isPal);


      // Method to get palindrome using Array.Reverse
      // char[] userWordArray = userWord.ToArray();
      // Array.Reverse(userWordArray);
      // string backwards = new string(userWordArray);
      //
      // Console.WriteLine(userWord == backwards);

      //Method to get palindrome using for loops

    }
  }
}
