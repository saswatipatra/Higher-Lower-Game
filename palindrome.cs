using System;

class Palindrome 
{
    static void Main()
    {
    Console.WriteLine("Enter first side of the triangle ");
    string userString = Console.ReadLine();
    char[] charArr = userString.ToCharArray();
    for(int i=0; i>charArr.Length; i--)
    {
    for(int  j=charArr.Length;  j=0 ; j--)
    {
      Array.Reverse (charArr,i , j);
    }
    }
   string reverseString= string.Join(",", charArr);
    if (userString==reverseString)
    {
      Console.WriteLine("it's a palindorme");

    }
    else
    {
      Console.WriteLine("Not a palindorme");
    }


    }
    // static bool checkPal(string userString)
    // {
    //   char[] charArr = userString.ToCharArray();
    //   for (int i = charArr.Length; i > 0; i--)
    //   {
    //     string reverse
    //   }
    // }
}