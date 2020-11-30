using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void TestGutterGame()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score);
        }
    }
}
