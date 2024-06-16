using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_FC
{
    internal class Player
    {
        public string Name { get; set; }
        public byte Number { get; set; }

        public Player(string name, byte number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nNumber: {Number}";
        }
    }
}
