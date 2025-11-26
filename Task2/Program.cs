class Program
{
    static void Main(string[] args)
    {
        // Create Car object
        Car car = new Car()
        {
            Brand = "Toyota",
            Speed = 120,
            Seats = 5
        };

        // Create Motorcycle object
        Motorcycle moto = new Motorcycle()
        {
            Brand = "Honda",
            Speed = 80,
            HasCarrier = true
        };

        // Demonstrate code reusability
        Console.WriteLine("=== Car Info ===");
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine("=== Motorcycle Info ===");
        moto.Start();
        moto.DisplayInfo();
        moto.Stop();
    }
}
