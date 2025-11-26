using System;
using System.Collections.Generic;

class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to store.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine($"{device.Brand} removed from store.");
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n--- All Devices in Store ---\n");
        foreach (var device in devices)
        {
            device.ShowInfo();
        }
    }
}
