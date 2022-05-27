using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bird : Animal
    {
        public string fly;

        public Bird(string fly, string Name, double Weight, string Class, string Description, string Sound) : base(Name, Weight, Class, Description, Sound)
        {
            this.fly = fly;
        }

        public override void Show()
        {
            Console.WriteLine($"Птица: \n летать: {fly}");
            base.Show();
        }
    }
}
