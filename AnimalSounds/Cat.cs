namespace AnimalSounds;

public class Cat
{
    public void DescribeCat()
    {
        Console.WriteLine($"{GetType().Name} makes sound {MakeSound()}");
    }

    private string MakeSound()
    {
        return "Meow";
    }
}