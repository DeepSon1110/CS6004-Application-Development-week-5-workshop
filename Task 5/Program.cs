public class Program
{
    public static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Acer", 120000);
        Smartphone smartphone = new Smartphone("Samsung", 80000);

        //Add devices to the store
        store.AddDevice(laptop);
        store.AddDevice(smartphone);

        //Display all device details
        store.ShowAllDeviceDetails();
    }
}