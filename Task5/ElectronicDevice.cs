using System;

// Abstract Class
abstract class ElectronicDevice
{
    private string brand;
    private double price;

    // Encapsulated properties
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Constructor
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    // Abstract method
    public abstract void ShowInfo();
}
