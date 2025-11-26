public class Vehicle
{
    // Properties
    public string Brand { get; set; }
    public int Speed { get; set; }

    // Methods
    public void Start()
    {
        Console.WriteLine($"{Brand} started.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} stopped.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed} km/h");
    }
}
