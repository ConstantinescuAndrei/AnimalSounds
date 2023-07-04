namespace AnimalSounds;

public class Animal
{
    public void DescribeAnimal()
    {
        Console.WriteLine($"{GetType().Name} makes sound {MakeSound()}");
    }

    public virtual string MakeSound()
    {
        return "No sound";
    }
}