using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exercises.Classes
{
    internal class Door
    {
        private string color { get; set; }

        public Door(string color)
        {
            this.color = color;
        }

        public void showData()
        {
            Console.WriteLine($"I am a door, my color is {this.color}");
        }

    }
}
