using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Character
    {
        public string Name { get; set; }
        public UInt64 Health { get; set; }
        public UInt64 CurrentHealth { get; set; }
        public int Strong {  get; set; }
        public int Defense { get; set; }
        public UInt64 Level { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }

    }
}
