namespace DemoApp;

public class Hospital : IHospital
{
    public void Cure(IPerson person)
    {
        Console.WriteLine("Cure person");
    }
}