using System;

class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price) { }

    public void TurnOnBattery()
    {
        Console.WriteLine($"{Brand} laptop battery is now ON.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Laptop Details:");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Price: ${Price}");
        TurnOnBattery();
        Console.WriteLine();
    }
}
