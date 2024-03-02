using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private static Random rand = new Random();
        private int rollValue; //Value of individual roll

        public Die()
        {
            roll_Value = dieRoll(); //Roll Value is assigned to dieRoll, which picks a random number between 1 and 6
        }
        public int roll
        {
            get { return rollValue; }
        }
        private int dieRoll()
        {
            return rand.Next(1,7); //Picks a random number between 1 and 6
        }
    }
}
