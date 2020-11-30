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
        [TestMethod]
        public void TestOneSpare()
        {
            var game = SetupGame();
            RollSpar(game);
            game.Roll(3);
            RollPins(game, 17, 0);
            Assert.AreEqual(16, game.Score);
        }
        [TestMethod]
        public void TestOneStrike()
        {
            var game = SetupGame();
            RollStrike(game);
            game.Roll(3);
            game.Roll(4);
            RollPins(game, 16, 0);
            Assert.AreEqual(24, game.Score);
        }
        [TestMethod]
        public void TestPerfectGame()
        {
            var game = SetupGame();
            RollPins(game, 12, 10);
            Assert.AreEqual(300, game.Score);
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
        private void RollSpar(Game game)
        {
            game.Roll(5);
            game.Roll(5);
        }
        private void RollStrike(Game game)
        {
            game.Roll(10);
        }
        #endregion
    }
}
