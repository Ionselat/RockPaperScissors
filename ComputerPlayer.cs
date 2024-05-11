using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ComputerPlayer : IPlayer
    {
        private Random rng = new Random();
        public Choice GetChoice()
        {
            Choice p2 = (Choice)rng.Next(0, 3);
            return p2;
        }
    }
}
