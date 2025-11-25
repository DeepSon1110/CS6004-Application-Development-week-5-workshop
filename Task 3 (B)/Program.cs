public class Program
{
    public static void Main(string[] args)
    {
        //creating object of derived classes
        //obj of nepali teacher
        NepaliTeacher nepTeach = new NepaliTeacher();
        nepTeach.Name = "Mr.khadka";
        Console.WriteLine("Teacher Name: " + nepTeach.Name);
        nepTeach.Teaching();
        nepTeach.SalaryInfo();

        Console.WriteLine();

        //obj of English teacher
        EnglishTeacher engTeach = new EnglishTeacher();
        engTeach.Name = "Mrs.karki";
        Console.WriteLine("Teacher Name: " + engTeach.Name);
        engTeach.Teaching();
        engTeach.SalaryInfo();
        Console.ReadLine();
    }
}