using Autofac;

namespace DemoApp;

public class ContainerConfiguration
{
    public static IContainer Configure()
    {
        ContainerBuilder builder = new ContainerBuilder();
        builder.RegisterType<Person>().As<IPerson>();
        builder.RegisterType<College>().As<IEducationalInstitute>();
        builder.RegisterType<Hospital>().As<IHospital>();
        builder.RegisterType<Home>().As<IHome>();
        return builder.Build();
    }
}