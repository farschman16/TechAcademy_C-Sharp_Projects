using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            const string casinoName = "Farsch Casino";


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false; //valid answer defaults to false
            int bank = 0; //bank defaults to 0
            while (!validAnswer) //while loop, while validAnswer is false
            {
                Console.WriteLine("And how much money did you bring today?"); //console will show this line
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //parses (converts to 32 bit integer, out a valid output)
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals or letters."); //if still invalid format, show this message
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\farsc\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id); //logs the player's Id when they start
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDBWithException(ex); //updates the database with the exception (logs it)
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.Write("An error occured. Please contact your System Administrator.");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }

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

        private static void UpdateDBWithException(Exception ex) //creating a process to write to the database log
        {
            //this is what ties to our database
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //creating values to feed into ADO.NET
            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) " +
                                 " VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString)) //names the sql connection
            {
                SqlCommand command = new SqlCommand(queryString, connection); //setting up parameters we're adding
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //these tie to the columns in our database
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeSTamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //gets data type, converts to string and adds to db
                command.Parameters["@ExceptionMessage"].Value = ex.Message; //adds the exception message
                command.Parameters["@TimeStamp"].Value = DateTime.Now; //adds the current date and time to the database

                connection.Open(); //opens connection to database
                command.ExecuteNonQuery(); //nonquery because we're only writing, not querying
                connection.Close(); //closes connection
            }
        }
        private static List<ExceptionEntity> ReadExceptions() //creating method ReadExceptions
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
