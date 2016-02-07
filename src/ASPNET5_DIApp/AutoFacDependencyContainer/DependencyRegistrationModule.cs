using ASPNET5_DIApp.Models;
using ASPNET5_DIApp.Services;
using Autofac;

namespace ASPNET5_DIApp.AutoFacDependencyContainer
{
    public class DependencyRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeInfoService>().As<IService<EmployeeInfo>>();
        }
    }
}
