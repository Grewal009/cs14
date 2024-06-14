namespace DemoApp;

public class College : IEducationalInstitute
{
    public void Teach(IPerson person)
    {
        Console.WriteLine("Educate person in college");
    }
}