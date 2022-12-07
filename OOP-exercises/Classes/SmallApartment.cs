using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_exercises.Classes
{
    internal class SmallApartment : House
    {
        public SmallApartment(double area, Door door) : base(area)
        {
            if (area >= 50)
            {
                Console.WriteLine("Area is " + area);
            }
            else
                Console.WriteLine("Area of the apartment should be bigger than 50m2.");
        }
    }
}
