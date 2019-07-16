using System;

class HigherLower
{
    static void Main()
    {
      Console.WriteLine("Would you like to play the higher/lower game? Pick a number between 1-100. (Yes/No)");
      string readyCheck = Console.ReadLine();
      if(readyCheck == "Yes" || readyCheck =="yes")
      {
        int min = 1;
        int max = 100;
        string status= "";
        int num= RandomNumber(min, max);
       
        while(status != "correct" || status!= "Correct")
        {
        Console.WriteLine("Is your number higher or lower than " + num +" ? (Higher/Lower/Correct))");
        string readNum = Console.ReadLine();
        status= readNum;
        if(readNum=="Higher"||readNum=="higher")
        { if (num > min)
          {
              min = num+1;
          }
          num =  RandomNumber(min,max); 
         
        }
        else if (readNum=="Lower" || readNum == "lower")
        {
          if (num < max)
          {
              max = num-1;
          }
          num =  RandomNumber(min,max);
        }
        else{
          Console.WriteLine("The computer guessed your number!");
          return;
        }
       }
      }
    }
  static int RandomNumber(int min, int max)
  {
    Random randomNum = new Random();
    int index = randomNum.Next(min,max);
    return index;
  }
}