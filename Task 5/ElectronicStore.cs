public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to the store.");
    }
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
            Console.WriteLine($"{device.Brand} removed from the store.");
        else
            Console.WriteLine("Device not found.");
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n===== Device Details in Store =====");

        foreach (var device in devices)
        {
            device.ShowInfo();   


            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine("-----------------------------------");
        }


    }

}