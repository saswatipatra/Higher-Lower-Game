using System;
using Highlow.Models;
namespace Highlow
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Would you like to play the higher/lower game? Pick a number between 1-100. (Yes/No)");
      string readyCheck = Console.ReadLine();
      if(readyCheck == "Yes" || readyCheck =="yes")
      {
        HigherLower.RandomNumber();
        string readNum="";
        while(readNum != "correct" || readNum!= "Correct")
        {
        Console.WriteLine("Is your number higher or lower than " + HigherLower.GetNumber() +" ? (Higher/Lower/Correct))");
        readNum = Console.ReadLine();
        if(readNum=="Higher"||readNum=="higher")
        {
          HigherLower.higher(HigherLower.GetNumber());
        }
        else if (readNum=="Lower" || readNum == "lower")
        {
        HigherLower.lower(HigherLower.GetNumber());
        }
        else{
          Console.WriteLine("The computer guessed your number!");
          return;
        }
       }
      }
    }
  }
}
