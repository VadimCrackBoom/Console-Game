using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reward
    {
        public int Exp { get; }
        public UInt64 Health { get; }
        public int Strong { get; }
        public int Defense { get; }

        public Reward(int exp, UInt64 health, int strong, int defense)
        {
            Exp = exp;
            Health = health;
            Strong = strong;
            Defense = defense;
        }
    }
}
