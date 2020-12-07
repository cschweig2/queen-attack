using System;
using System.Collections.Generic;
using QueenAttack.Logic;

namespace QueenAttack
{
  public class Program
  {
    public static void Main()
    {
      Queen whiteQueen = new Queen(4,1);
      Console.WriteLine("Welcome to the game of chess. Please enter your piece location at coordinate X: ");
      string strXCoord = Console.ReadLine();
      int xCoord = int.Parse(strXCoord);
      Console.WriteLine("Please enter your piece location at coordinate Y: ");
      string strYCoord = Console.ReadLine();
      int yCoord = int.Parse(strYCoord);

      bool attack = Queen.CanQueenAttack(xCoord, yCoord);

      if (attack)
      {
        Console.WriteLine("The queen has won");
      } 
      else 
      {
        Console.WriteLine("You have bested the queen");
      }
    }
  }
}
// chessboard is 8x8
// user submits coordinates
// the program creates an instance of Queen class with X and Y coordinates
// the Queen class has a method that takes the user's coordinates as argument
// the method will return true if the queen can attack 
// the user should see the result displayed