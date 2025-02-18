using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Level
    {
        public UInt64 Number { get; }
        public string Name { get; }
        public List<Opponent> Opponents { get; }
        public Boss Boss { get; }
        public Reward Reward { get; }

        public Level(UInt64 number, string name, List<Opponent> opponents, Boss boss, Reward reward)
        {
            Number = number;
            Name = name;
            Opponents = opponents;
            Boss = boss;
            Reward = reward;
        }
    }
}
