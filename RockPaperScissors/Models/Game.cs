namespace RockPaperScissors
{
  public class Game
  {
    public static string GameLogic(string player1, string player2)
    {
      int value1 = int.Parse(player1);
      int value2 = int.Parse(player2);

      if (value1 == value2) 
      {
        return "Player 1 and Player 2 tie.";
      } 
      else if (value1 > value2)
      {
        return "Player 1 wins!";
      }
      else 
      {
        return "Nobody wins";
      }
    }
  }
}
