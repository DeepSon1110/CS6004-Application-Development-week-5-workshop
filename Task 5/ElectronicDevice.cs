using System.Security.AccessControl;

public abstract class ElectronicDevice
{
    //private fields
    private string brand;
    private double price;

    //public properties to access private fields
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set 
        {
            if (value > 0)
                Price = value;
            else
                Console.WriteLine("Price must be greater than 0.");
        }
    }

    //abstract method 
    public abstract void ShowInfo();

    //Constructor
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand; 
        this.price = price;
    }


}