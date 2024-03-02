using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        static void Menu() //Displays main menu
        {
            string menuOption; //Menu UI
            Console.WriteLine(" D I C E   R O L L I N G   G A M E ");
            Console.WriteLine("                                   ");
            Console.WriteLine("Select menu option:");
            Console.WriteLine("Start Game - Press 1");
            Console.WriteLine("Close Game - Press 2");
            Console.WriteLine("                                   ");
            menuOption = Console.ReadLine(); //User input
            switch (menuOption)
            {
                case "1": //Starts the game
                    startGame();
                    break;
                case "2": //Closes the game
                    closeGame();
                    break;
                default: //In event of invalid input
                    Console.WriteLine("Invalid input");
                    menuOption(); //Reloads main menu
                    break;
            }
        }
        static void startGame()
        {
            Console.WriteLine("Rolling three dice...")
            Die roll1 = new Die(); //Rolling all 3 dice
            Die roll2 = new Die();
            Die roll3 = new Die();
            Thread.Sleep(1000); //Waits a second to simulate dice rolling
            Console.WriteLine("                                   ");
            Console.WriteLine("Die 1 rolled a ", roll1.roll); //Outputting results
            Console.WriteLine("Die 2 rolled a ", roll2.roll);
            Console.WriteLine("Die 3 rolled a ", roll3.roll);
            Console.WriteLine("The sum of the rolls is ", (roll1.roll + roll2.roll + roll3.roll));
            restartGame(); //Option to play again
        }
        static void restartGame()
        {
            string restartOptions;
            Console.WriteLine("                                   ");
            Console.WriteLine("Play again? - Press 1");
            Console.WriteLine("Main Menu - Press 2");
            Console.WriteLine("                                   ");
            restartOptions = Console.ReadLine();
            switch (restartGame)
            {
                case "1":
                    startGame();
                    break;
                case "2":
                    Menu();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    restartGame();
                    break;
            }
        }
        static void closeGame()
        {
            Environment.Exit(0);
        }
    }
}
