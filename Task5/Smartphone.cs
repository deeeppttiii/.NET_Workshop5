using System;

class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price) { }

    public void EnableCamera()
    {
        Console.WriteLine($"{Brand} smartphone camera is now enabled.");
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Smartphone Details:");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Price: ${Price}");
        EnableCamera();
        Console.WriteLine();
    }
}
