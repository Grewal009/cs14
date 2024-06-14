namespace DemoApp;

public interface IPerson
{
    IEducationalInstitute School { set; }
    void TakeRefuge();
    void Study();
    void GetTreatment(IHospital hospital);
}