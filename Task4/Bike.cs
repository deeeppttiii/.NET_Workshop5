public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started with a kick start.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }
}
