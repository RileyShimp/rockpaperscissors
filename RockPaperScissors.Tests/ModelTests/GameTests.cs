using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameLogic_ReturnsAString_String()
    {
      string results = Game.GameLogic("1","1");
      Assert.AreEqual(typeof(string),results.GetType());
    }

    [TestMethod]
    public void GameLogic_ReturnsATie_String()
    {
      string results = Game.GameLogic("1","1"); 
      Assert.AreEqual("Player 1 and Player 2 tie.", results);
    }

      [TestMethod]
    public void GameLogic_ReturnsAWin_String()
    {
      string results = Game.GameLogic("2","1"); 
      string results2 = Game.GameLogic("1","2");
      Assert.AreEqual("Player 1 wins!", results);
      Assert.AreEqual("Player 2 wins!", results2);
    }

    [TestMethod]
    public void GameLogic_Handles3s_String()
    {
      string results = Game.GameLogic("3","1"); 
      string results2 = Game.GameLogic("1","3");
      Assert.AreEqual("Player 2 wins!", results);
      Assert.AreEqual("Player 1 wins!", results2);
    }
  }
}