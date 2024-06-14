namespace DemoApp;

public class School : IEducationalInstitute
{
    public void Teach(IPerson person)
    {
        Console.WriteLine("Educate person in school");
    }
}