using System;
using System.Collections.Generic;

namespace Hilo.Game
{
    public class Player
    {
        //Instancate values
        string highLow;
        string yesNo = "";
        Deck dealer = new Deck();
        int curCard;
        int nextCard;
        
        int score;
        bool isPlaying;
        public Player()
        {
            //Gives a current value for curCard and prints out first card
            highLow = "";
            score = dealer.GetScore();
            StartUp();
        }


        public void HighOrLow()
        {
            Console.Write("Higher or Lower?[h/y] ");
            CheckForHL();
        }

        //Error checker
        public void CheckForHL()
        {
            do
            {
                highLow = Console.ReadLine();

            } while (highLow != "h" || highLow != "l"); 
        }

        public void CheckForYN()
        {
            do
            {
                yesNo = Console.ReadLine();

            } while (yesNo != "y" || yesNo != "n"); 
        }

        public void StartUp()
        {
            //Basic setup for game
            curCard = dealer.GetCard();
            Console.WriteLine($"\n\nThe card is: {curCard}");
            
        }

        public void Game()
        {
            isPlaying = true;
            while (isPlaying)
            {
                nextCard = dealer.GetCard();
                HighOrLow();
                Console.WriteLine($"Next card was {nextCard}.");
                if (highLow == "h")
                {
                    if (nextCard >= curCard)
                    {
                        score += 100;
                        Console.WriteLine($"Your score: {score}");
                    }
                    else
                    {
                        score -= 75;
                        Console.WriteLine($"Your score: {score}");
                    }
                }
                else if(highLow == "l")
                {
                    if (nextCard <= curCard)
                    {
                        score += 100;
                        Console.WriteLine($"Your score: {score}");
                    }
                    else
                    {
                        score -= 75;
                        Console.WriteLine($"Your score: {score}");
                    }
                }
                if (score <= 0)
                {
                    isPlaying = false;
                    continue;
                }
                Console.WriteLine("Do you want to play again?[y/n] ");
                CheckForYN();
                if (yesNo == "n")
                {
                    isPlaying = false;
                    continue;
                }
                StartUp();
            }
            


        }
        public void StartGame()
        {
            Game();
        }
    }
}