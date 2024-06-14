namespace DemoApp;

public class Person
{
    private Home _home;
    private School _school;
    private Hospital _hospital;

    public School School {
        set
        {
            _school = value;
        }
    }

    public Person(Home home)
    {
        _home = home;
        _hospital = new Hospital();
    }

    public void TakeRefuge()
    {
        _home.ProvideShelter(this);
    }

    public void Study()
    {
        if (_school != null)
        {
            _school.Teach(this);
        }
        
    }

    public void GetTreatment()
    {
        _hospital.Cure(this);
    }
}