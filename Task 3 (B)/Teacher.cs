public class Teacher
{
    //attributes
    public string Name {get;set;}

    //methods
    //Teaching method
    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    //Method SalaryInfo
    public void SalaryInfo()
    {
        Console.WriteLine("Teacher receives monthly salary");
    }
}