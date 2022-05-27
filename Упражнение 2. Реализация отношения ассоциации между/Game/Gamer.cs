using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Gamer
    {
        string name;
        Dice seans;

        public Gamer(string name)
        {
            this.name = name;
            seans = new Dice();
        }

        public int SeansGame()
        {
            return seans.Roll();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
