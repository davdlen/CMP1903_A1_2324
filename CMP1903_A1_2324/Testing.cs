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
    }
}
