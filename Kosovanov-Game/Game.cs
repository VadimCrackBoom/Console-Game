using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public User User { get; }
        public List<Level> Levels { get; }
        public Level CurrentLevel { get; set; }

        public Game(User user, List<Level> levels)
        {
            User = user;
            Levels = levels;
        }
    }
}
