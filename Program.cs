using System;

namespace Palindrome {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      string userWord = Console.ReadLine();
      char[] userWordArray = userWord.ToCharArray();
      Array.Reverse(userWordArray);
      string backwards = new string(userWordArray);

      Console.WriteLine(userWord == backwards);

      // if (userWordReverse == userWordArray)
      // {
      //   Console.WriteLine("This is a palindrome");
      // }
    }
  }
}
