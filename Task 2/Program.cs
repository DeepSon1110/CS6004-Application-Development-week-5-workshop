class program
{
    static void Main(string[] args)
    {
        //car object 
        Car car = new Car();
        car.Brand = "Suzuki";
        car.speed = 120;
        car.Seats = 4;

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        //MOtorcycle Object 
        Motorcycle motor = new Motorcycle();
        motor.Brand = "honda";
        motor.speed = 100;
        motor.HasCarrier = true;

        motor.Start();
        motor.DisplayInfo();
        motor.Stop();

        


    }
}

