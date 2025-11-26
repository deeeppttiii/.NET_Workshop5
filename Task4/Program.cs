class Program
{
    static void Main(string[] args)
    {
        // Create Car object
        Car car = new Car();

        // Create Bike object
        Bike bike = new Bike();

        // ===== CAR =====
        Console.WriteLine("CAR:");
        car.Display();
        car.StartEngine();
        car.StopEngine();

        Console.WriteLine();

        // ===== BIKE =====
        Console.WriteLine("BIKE:");
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();
    }
}
