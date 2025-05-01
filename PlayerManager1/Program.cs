using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    public class Program
    {
        private List<Player> players = new List<Player>();

        private static void Main(string[] args)
        {
            ShowMenu();
            switch (Console.ReadLine()){
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "0":
                    break;
                default:
                Console.WriteLine("The option choosed does not exist.");
                    break;
            }
        }

        private static void ShowMenu()
        {
            string msg = "1 - Insert a new player\n"
            + "2 - Show a list of all players\n"
            + "3 - Show a list of all player with greater score than\n"
            + "0 - Exit";

            Console.WriteLine(msg);
        }
    }
}
