public class Program
{
    //creating main method
    public static void Main(string[] args)
    {
        //creting object of derived classes
        //creating object of car class
        Car myCar = new Car();
        myCar.StartEngine();
        myCar.StopEngine();
        myCar.Display();

        Console.WriteLine();

        //creating object of bike class
        Bike myBike = new Bike();
        myBike.StartEngine();
        myBike.StopEngine();
        myBike.Display();


    }
}
