namespace AnimalSounds;

public class Parrot
{
     public void DescribeParrot()
        {
            Console.WriteLine($"{GetType().Name} makes sound {MakeSound()}");
        }
    
        private string MakeSound()
        {
            return "chirps";
        }
}