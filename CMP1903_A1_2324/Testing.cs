using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private Die debugDie1 = new Die();
        private Die debugDie2 = new Die();
        private Die debugDie3 = new Die();
        private Die debugRoll = new Die();
        public void debugInfo()
        {
            Debug.Assert(invalidSum(), "Sum of dice is incorrect.");
            Debug.Assert(invalidRollParameter(), "Dice roll is not within valid parameter range (1-6).")
        }
        private bool invalidSum()
        {
            int rollSum = debugDie1 + debugDie2 + debugDie3;
            return rollSum == (debugDie1.roll + debugDie2.roll + debugDie3.roll);
        }
        private bool invalidRollParameter()
        {
            return debugRoll.roll <= 6 && debugRoll.roll >=1;
        }
    }
}
