namespace OOP_exercises.Classes
{
    internal class House
    {
        private double area { get; set; }
        private Door door1;

        public House(double area)
        {
            this.area = area;
        }
        public House(double area, Door door1)
        {
            this.area = area;
            this.door1 = door1;
        }

        public void showData()
        {
            Console.WriteLine($"My area is {this.area} m2");
        }


        public Door GetDoor()
        {
            return this.door1;
        }
    }
}
