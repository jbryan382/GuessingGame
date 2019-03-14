using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      var Guessing = true;
      var count = 0;
      var Guess = 100;
      var Max = 100;
      var Min = 0;
      Console.WriteLine("Think of a number between 1-100.");
      while (Guessing == true)
      {
        count++;
        Console.WriteLine($"Is your number {Guess}");
        var input = Console.ReadLine();
        if (input == "yes")
        {
          Guessing = false;
        }
        else
        {
          Console.WriteLine("higher or lower?");
          var HOrL = Console.ReadLine();
          if (HOrL == "higher")
          {
            Guess = (Min + Max) / 2;
            Min = Guess;
          }
          else
          {
            Guess = (Min + Max) / 2;
            Max = Guess;
          }
        }
      }
      Console.WriteLine($"Hey, I guess a total of {count} times and your number was {Guess}");

    }
  }
}
