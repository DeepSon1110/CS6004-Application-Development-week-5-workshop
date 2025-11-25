class Program
{
    public static void Main(string[] args)
    {
        Printer printer = new Printer();

        //calling method Print(string message)
        printer.print("Hellosandy");

        //calling method print(int number)
        printer.print(5);

        //calling method print(string message, int count)
        printer.print("Hellosandy", 3);

        Console.ReadLine();
    }
}