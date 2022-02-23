using System;
using RockPaperScissors;

namespace RPSGame {
  public class Program 
  {
  public static void Main() 
  {
    Console.WriteLine("----------------------");
    Console.WriteLine("Welcome to rock, paper scissors. If you have never played this game before, go ahead and Google that, I have better things to do with my time. Press ENTER to continue.");
    Console.ReadKey();
    Console.WriteLine("----------------------");
    Console.WriteLine("Player 1, it is your turn. Player 2, close your eyes. Player 1, enter (1) to throw paper, (2) to throw scissors, or (3) to throw rock, then press enter. It would really be a bummer if you entered anything except a 1, 2 or 3, so don't do that.");
    string player1 = Console.ReadLine();
    Console.WriteLine("----------------------");
    Console.WriteLine("Player 2, it is your turn. Player 1, close your eyes. Player 2, enter (1) to throw paper, (2) to throw scissors, or (3) to throw rock, then press enter. I cannot stress enough that I will immediately die if you enter anything except a 1, 2 or 3, and I have a family.");
    string player2 = Console.ReadLine();
    string result = Game.GameLogic(player1, player2);
    Console.WriteLine("----------------------");
    Console.WriteLine("Thanks for playing! " + result + " GOODBYE!");
    Console.WriteLine("----------------------");
  }
  }
}