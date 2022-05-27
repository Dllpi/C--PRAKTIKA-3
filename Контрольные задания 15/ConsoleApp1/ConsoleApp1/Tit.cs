using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tit : Bird
    {
        public Tit(string fly, string Name, double Weight, string Class, string Description, string Sound) : base(fly, Name, Weight, Class, Description, Sound)
        {
        }

        public string release_the_bird()
        {
            return "синица улeтела!";
        }
    }
}
