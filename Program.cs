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
      Console.WriteLine(userNum);

      //make game class
      //while playing writelines must match random number generator
      //if false, game exits
      //if true, continue playing keep adding more numbers

    }
  }
}
