public class Laptop : ElectronicDevice
{   
    //constructor
    public Laptop(string brand, double price) : base(brand, price)
    {

    }

    //method 
    public void TurnOnBattery()
    {
       Console.WriteLine("Laptop battery is turned on.");
    }

    //overriding ShowInfo method
    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}
