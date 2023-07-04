// See https://aka.ms/new-console-template for more information

using AnimalSounds;

List<Animal> animalsList = new List<Animal>();

animalsList.Add(new Cat());
animalsList.Add(new Dog());
animalsList.Add(new Parrot());

foreach (Animal animal in animalsList)
{
    animal.DescribeAnimal();
}
