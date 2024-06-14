// See https://aka.ms/new-console-template for more information

using System.Data;
using Autofac;
using DemoApp;

/* old way
Home home = new Home();
Person person = new Person(home); // constructor injection
person.TakeRefuge();
// person.School = new School(); // property injection
person.School = new College(); // using interface

person.Study();
Hospital hospital = new Hospital();
person.GetTreatment(hospital); // method injection 
*/

var container = ContainerConfiguration.Configure();
using (var scope = container.BeginLifetimeScope())
{
    IPerson person = scope.Resolve<IPerson>();
    person.TakeRefuge();
    person.School = scope.Resolve<IEducationalInstitute>();
    person.Study();
    person.GetTreatment(scope.Resolve<IHospital>());
    
}






