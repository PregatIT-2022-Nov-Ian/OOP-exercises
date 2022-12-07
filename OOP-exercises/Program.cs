

using OOP_exercises.Classes;

Door door = new Door("pink");
SmallApartment smallApartment = new SmallApartment(50, door);
Person person = new Person("Maria", smallApartment);
person.showData();