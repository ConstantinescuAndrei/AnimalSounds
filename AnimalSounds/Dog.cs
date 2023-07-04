namespace AnimalSounds;

public class Dog
{
    public void DescribeDog()
    {
        Console.WriteLine($"{GetType().Name} makes sound {MakeSound()}");
    }

    private string MakeSound()
    {
        return "Ham";
    }
}