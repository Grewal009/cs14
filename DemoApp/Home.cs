namespace DemoApp;

public class Home : IHome
{
    public void ProvideShelter(IPerson person)
    {
        Console.WriteLine("Stay Home");
    }

}