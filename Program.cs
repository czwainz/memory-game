using System;

namespace memory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Let's play a game! Try to remember all the numbers that come out!");
      Console.WriteLine("Pick a number");
      string userInput = Console.ReadLine();

      int userNum = Int32.Parse(userInput);

      Random rand = new Random();
      int randNum = rand.Next(0, 9);
      Console.WriteLine(randNum);
      int randomSeq = randNum ^ 3;

      bool playing = true;

      while (playing)
      {
        if (randNum == userNum)
        {
          Console.WriteLine("Word, you right");
          Console.Clear();
          Console.WriteLine("Now remember this one and guess again!");

        }
        // playing = false;
        Console.Clear();
        System.Console.WriteLine("Dawg, you wrong");
      }

      Console.WriteLine("DAWGGGGG");


      //make game class
      //while playing writelines must match random number generator
      //if false, game exits
      //if true, continue playing keep adding more numbers

    }
  }
}
