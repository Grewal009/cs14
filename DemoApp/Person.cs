namespace DemoApp;

public class Person : IPerson
{
    private IHome _home;
    private IEducationalInstitute _school;

    public IEducationalInstitute School {
        set
        {
            _school = value;
        }
    }

    public Person(IHome home)
    {
        _home = home;
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

    public void GetTreatment(IHospital hospital)
    {
        
        hospital.Cure(this);
    }
}