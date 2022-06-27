using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Farsch Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();


            //creates a new instance of the TwentyOneGame, adds players to game.
            //TwentyOneGame game = new TwentyOneGame(); //new instance of TwentyOneGame called "game"
            //game.Players = new List<string>() { "Matt", "Tony", "Andy" }; //in-line initializing into the list using curly braces
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame(); //new instance of the game
            //game.Players = new List<Player>(); //instantiates the list "Players"
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player; //same as "game = game + player;
            //game -= player; //same as "game = game - player;



            //******Lambda function finding the number of cards with the value of Ace
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);

            //*******Lambda function creating a list of cards with value of King, foreach loop to print each
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //****** additional Lambda function
            //List<int> numberList = new List<int>() { 1, 2, 52, 432, 88 };
            //int sum = numberList.Where(x => x > 20).Sum();
            //Console.WriteLine(sum);
        }

    }
}
