using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PlayerManager2
{
    public class Program
    {
        private List<Player> players = new List<Player>();
        private static bool stillRun = true;

        private Program()
        {
            players.Add(new Player("Arthur", 999));
            players.Add(new Player("Kanye", 666));
        }


        private static void Main(string[] args)
        {
            // Instancia do program para inciar o programa. 
            Program prog = new Program();
            // Iniciar programa
            prog.StartApp();
        }

        private void StartApp()
        {
            // Ciclo principal
            while (stillRun)
            {
                ShowMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        AddNewPlayer();
                        break;
                    case "2":
                        ListPlayers();
                        break;
                    case "3":
                        ListPlayersWithHighScore();
                        break;
                    case "0":
                        stillRun = false;
                        break;
                    default:
                        Console.WriteLine("The option choosed does not exist.");
                        break;
                }

                Console.WriteLine("Press any key......");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void ShowMenu()
        {
            string msg = "1 - Insert a new player\n"
            + "2 - Show a list of all players\n"
            + "3 - Show a list of all player with greater score than\n"
            + "0 - Exit";

            Console.WriteLine(msg);
        }

        public void AddNewPlayer()
        {
            Console.WriteLine("New player's name:");
            string name = Console.ReadLine();
            Console.WriteLine("New player's score:");
            int score = int.Parse(Console.ReadLine());

            players.Add(new Player(name, score));
        }

        public void ListPlayers()
        {
            foreach (Player p in players)
            {
                Console.WriteLine(p);
            }
        }

        public void ListPlayersWithHighScore()
        {
            Console.Write("Minimum score: ");
            int.TryParse(Console.ReadLine(), out int minScore);

            IEnumerable<Player> result = GetPlayersWithScoreGreaterThan(minScore);

            Console.WriteLine("\nPlayers with greater score than " + minScore + ":");

            foreach (Player player in result)
            {
                Console.WriteLine(player);
            }

        }

        public IEnumerable<Player> GetPlayersWithScoreGreaterThan(int value)
        {
            List<Player> result = new List<Player>();

            foreach (Player player in players)
            {
                if (player.Score > value)
                {
                    result.Add(player);
                }
            }

            return result;
        }
    }
}


