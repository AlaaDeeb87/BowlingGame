using System;

namespace BowlingGame
{
    public class Game
    {
        public int Score { get; set; }

        public void Roll(int pinsHit)
        {
            Score += pinsHit;
        }
        public Game()
        {
            Score = 0;
        }
    }
}