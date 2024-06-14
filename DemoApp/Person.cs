namespace DemoApp;

public class Person
{
    private Home _home;
    private School _school;
    private Hospital _hospital;

    public Person()
    {
        _home = new Home();
        _school = new School();
        _hospital = new Hospital();
    }

    public void TakeRefuge()
    {
        _home.ProvideShelter(this);
    }

    public void Study()
    {
        _school.Teach(this);
    }

    public void GetTreatment()
    {
        _hospital.Cure(this);
    }
}