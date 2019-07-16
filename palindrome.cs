using System;

class Palindrome 
{
    static void Main()
    {
    Console.WriteLine("Enter the word to check whether it's a palindorme or not: ");
    string userString = Console.ReadLine();
    bool status=getStatus(userString);
    if (status== true)
    {
      Console.WriteLine("it's a palindorme");

    }
    else
    {
      Console.WriteLine("Not a palindorme");
    }
    }
    public static bool getStatus(string userString)
    {
    char[] charArr = userString.ToCharArray();
    Array.Reverse (charArr);
    string reverseString= new string(charArr);
    return userString.Equals(reverseString);
    }

}