using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exercises.Classes
{
    internal class Person
    {
        public string name { get; set; }
        public House house;

        public Person(string name, House house)
        {
            this.name = name; 
            this.house = house;
        }

        public void showData()
        {
            Console.WriteLine("Name: " + name);
            this.house.showData();
        }
    }
}
