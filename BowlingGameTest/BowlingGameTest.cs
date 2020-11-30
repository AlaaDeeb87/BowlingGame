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
            var game = SetupGame();
            RollPins(game, 20, 0);
            Assert.AreEqual(0, game.Score);
        }

       

        [TestMethod]
        public void TestHittingOnePinPerRoll()
        {
            var game = SetupGame();
            RollPins(game, 20, 1);
            Assert.AreEqual(20, game.Score);
        }
        #region Private Mathods
        private Game SetupGame()
        {
            return new Game();
        }
        private void RollPins(Game game, int numberOfRolls, int pinsHitPerRoll)
        {
            for (int i = 0; i < numberOfRolls; i++)
            {
                game.Roll(pinsHitPerRoll);
            }

        }
        #endregion
    }
}
