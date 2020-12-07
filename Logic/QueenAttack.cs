namespace QueenAttack.Logic
{
  public class Queen
  {
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }

    public Queen(int xCoordinate, int yCoordinate)
    {
      XCoordinate = xCoordinate;
      YCoordinate = yCoordinate;
    }

    public static bool CanQueenAttack(int x, int y)
    {
      if (x == 4 || y == 1)
      {
        return true;
      }
      // else if ((x => x + 1) || (y => y + 1))
      // {
      //   return true;
      // }
      else
      {
        return false;
      }
    }
  }
}