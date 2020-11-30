using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private List<int> _rolls = new List<int>(21);
        private int currentRoll = 0;
        //public Game()
        //{
        //    Score = 0;
        //}
        public Game()
        {
            for (int i = 0; i < 22; i++)
            {
                _rolls.Add(0);
            }
        }
        private int _currentRoll =0;
        
        public void Roll(int pinsHit)
        {
            ////Score += pinsHit;
            //_rolls.Add(pinsHit);
            //currentRoll++;
            _rolls[_currentRoll++] = pinsHit;
        }
      
        public int Score 
        {
            get
            {
                int score = 0;
                int fremeIndex = 0;
                for (int frame =0; frame <10; frame++)
                {
                    if (IsStrike(fremeIndex))
                    {
                        score += 10 + StrikeBonus(fremeIndex);
                        fremeIndex ++;
                    }
                    else if (IsSpare(fremeIndex))
                    {
                        score += 10 + SpareBonus(fremeIndex);
                        fremeIndex += 2;
                    }
                    else
                    {
                        score += NormalFrameBonus(fremeIndex);
                        fremeIndex += 2;
                    }
                    
                }
                return score;
            }
        }

        private int NormalFrameBonus(int fremeIndex)
        {
            return _rolls[fremeIndex ] + _rolls[fremeIndex + 1];
        }

        private int SpareBonus(int fremeIndex)
        {
            return _rolls[fremeIndex + 2];
        }

        private int StrikeBonus(int fremeIndex)
        {
            return _rolls[fremeIndex+1] + _rolls[fremeIndex + 2];
        }

        private bool IsStrike(int fremeIndex)
        {
            return _rolls[fremeIndex] == 10;
        }

        private bool IsSpare(int fremeIndex)
        {
            return _rolls[fremeIndex] + _rolls[fremeIndex + 1] == 10;
        }
    }
}