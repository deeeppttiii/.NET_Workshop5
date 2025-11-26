using System;
class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        // Create devices
        Laptop myLaptop = new Laptop("Dell", 1200);
        Smartphone myPhone = new Smartphone("Samsung", 900);

        // Add devices to store
        store.AddDevice(myLaptop);
        store.AddDevice(myPhone);

        // Display all device info
        store.ShowAllDeviceDetails();
    }
}
