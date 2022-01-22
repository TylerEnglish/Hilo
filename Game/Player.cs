using System;
using System.Collections.Generic;

namespace Hilo.Game
{
    public class Player
    {
        //Instancate values
        string highLow;
        Deck dealer = new Deck();
        int curCard;
        public Player()
        {
            highLow = "h";
            curCard = dealer.GetCard();
            
            Console.WriteLine($"\n\nThe card is: {curCard}");
            
        }




        public void StartGame()
        {

        }
    }
}