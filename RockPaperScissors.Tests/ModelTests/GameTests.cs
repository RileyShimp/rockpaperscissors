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
  }
}