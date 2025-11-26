public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with a smooth ignition.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped safely.");
    }
}
