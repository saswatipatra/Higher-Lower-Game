using System;
namespace Highlow.Models
{
class HigherLower
{
  private static int _number;
  private static int _min = 1;
  private static int _max = 100;
  public static int GetNumber()
    {
      return _number;
    }
  public static void RandomNumber()
    {
      Random randomNum = new Random();
      _number = randomNum.Next(_min,_max);
    }

public  static void higher(int randNum)
  {
      Random randomNum = new Random();
    if (randNum > _min)
      {
          _min = randNum+1;
      }
      _number = randomNum.Next(_min,_max);
  }
public  static void lower(int randNum)
  {
    Random randomNum = new Random();
    if (randNum < _max)
    {
        _max = randNum-1;
      }
      _number = randomNum.Next(_min,_max);
  }
}
}
