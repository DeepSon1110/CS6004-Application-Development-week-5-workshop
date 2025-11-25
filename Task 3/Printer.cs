public class Printer
{
    //methods
    //method to print a message to the console
    public void print(string message)
    {
       Console.WriteLine("message :" + message);
    }

    //method to Print an integer
    public void print(int number)
    {
       Console.WriteLine("number :" + number);
    }

    //method to print message multiple times
    public void print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }

    
}
