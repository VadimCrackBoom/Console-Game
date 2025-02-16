using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        public User User { get; set; }

        public UInt64 Levels { get; set; }
    }

    class User : Game
    {
        public string Name { get; set; }


    }

    class Hero : Game
    {
        public UInt64 MaxHealth_Hero { get; set; }
        public UInt64 CurrentHealth_Hero { get; }
        public UInt64 Level_Hero { get; set; }
        public UInt64 Exp_Hero { get; set; }
        public int MaxAttack_Hero { get; set; }
        public int MinAttack_Hero { get; set; }
        public int Protected_Hero { get; set; }
    }

    class Opponent : Game
    {
        public UInt64 MaxHealth_Opponent { get; set; }
        public UInt64 CurrentHealth_Opponent { get; set; }
        public UInt64 Level_Opponent { get; set; }
        public UInt64 Exp_Opponent { get; set; }
        public int MaxAttack_Opponent { get; set; }
        public int MinAttack_Opponent { get; set; }
        public int Protected_Opponent { get; set; }

    }

    class Boss : Game
    {
        public UInt64 MaxHealth_Boss { get; set; }
        public UInt64 CurrentHealth_Boss { get; set; }
        public UInt64 Level_Boss {  get; set; }
        public int MaxAttack_Boss { get; set; }
        public int MinAttack_Boss { get; set; }
        public int Protected_Boss { get; set; }

    }

    class Levels: Game
    {
        public List<Levels> levels;
    }
}