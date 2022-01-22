using System;

namespace Hilo.Game
{
    public class Deck
    {
        //card can only be from 1-13
        int card;
        int score;
        public Deck()
        {
            score = 0;
            card = 0;
        }

        public int GetCard()
        {
            Random num = new Random();
            //getting random card number from 1-13
            card = num.Next(1,14);
            return card;
            
        }
        
    }
}