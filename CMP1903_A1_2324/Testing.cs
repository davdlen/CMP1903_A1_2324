using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private Die debugDie1 = new Die(); //Rolling 3 dice for sum check
        private Die debugDie2 = new Die();
        private Die debugDie3 = new Die();
        private Die debugRoll = new Die(); //Extra die for parameter check
        public void debugInfo()
        {
            Debug.Assert(invalidSum(), "Sum of dice is incorrect."); //Displayed for incorrect sum
            Debug.Assert(invalidRollParameter(), "Dice roll is not within valid parameter range (1-6).") //Displayed for incorrect parameter
        }
        private bool invalidSum()
        {
            int rollSum = debugDie1 + debugDie2 + debugDie3; //Checking if the sum calculated is correct
            return rollSum == (debugDie1.roll + debugDie2.roll + debugDie3.roll);
        }
        private bool invalidRollParameter()
        {
            return debugRoll.roll <= 6 && debugRoll.roll >=1; //Checking that value is less than or equal to 6 and greater than or equal to 1
        }
        string debugOptions;
        Console.WriteLine("                              "); //Debug menu after debug has run
        Console.WriteLine("Select debug menu option: ");
        Console.WriteLine("Rerun Debug - Press 1");
        Console.WriteLine("Main Menu - Press 2");
        Console.WriteLine("Close Game - Press 3");
        Console.WriteLine("                              ");
        debugOptions = Console.ReadLine();
        switch (debugOptions)
        {
            case "1": //Restarts debug mode
                enterDebug();
                break;
            case "2": //Back to main menu
                Menu();
                break;
            case "3": //Closes application
                closeGame();
                break;
            default: //In event of invalid input
                Console.WriteLine("Invalid input.");
                menuOption();
                break;
        }            
    }
}
