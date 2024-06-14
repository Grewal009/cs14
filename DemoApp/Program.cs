// See https://aka.ms/new-console-template for more information

using DemoApp;

Home home = new Home();
Person person = new Person(home); // constructor injection
person.TakeRefuge();
person.School = new School(); // property injection
person.Study();
person.GetTreatment();  