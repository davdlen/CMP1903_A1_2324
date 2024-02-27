using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int dieValue = rand.Next(1, 7);
            Console.WriteLine(dieValue);
        }


    }
}
