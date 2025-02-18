using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Name { get; }
        public Hero Hero { get; }

        public User(string name, Hero hero)
        {
            Name = name;
            Hero = hero;

        }
    }
}
