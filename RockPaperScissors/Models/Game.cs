namespace RockPaperScissors
{
  public class Game
  {
    public static string GameLogic(string player1, string player2)
    {
      int value1 = int.Parse(player1);
      int value2 = int.Parse(player2);
      string win1 = "Player 1 wins!";
      string win2 = "Player 2 wins!";

      if (value1 == value2) 
      {
        return "Player 1 and Player 2 tie.";
      } 
      else if (value1 == 3 && value2 == 1)
      {
        return win2;
      }
      else if (value1 == 1 && value2 == 3)
      {
        return win1;
      }
      else if (value1 > value2)
      {
        return win1;
      }
      else if (value2 > value1)
      {
        return win2;
      }
      else 
      {
        return "Error : Please enter number between 1 and 3";
      }
    }
  }
}
