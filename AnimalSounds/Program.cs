// See https://aka.ms/new-console-template for more information

using AnimalSounds;

List<Animal> animalsList = new List<Animal>
    { new Cat(), new Dog(), new Parrot(), new Horse(), new Pig(), new Sheep(), new Fox() };

foreach (Animal animal in animalsList)
{
    animal.DescribeAnimal();
}