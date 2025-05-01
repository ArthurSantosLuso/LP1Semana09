using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        public string Name { get; }
        public int Score { get; set; }
    }
}