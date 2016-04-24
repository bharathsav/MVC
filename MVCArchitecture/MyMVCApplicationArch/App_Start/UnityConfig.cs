using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
//using Services;
//using Services.Interfaces;
//using Domain.Interfaces;
//using Infrastructure.Data;

namespace MyMVCApplicationArch
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterTypes(AllClasses.FromLoadedAssemblies(),
                                WithMappings.FromMatchingInterface,
                                WithName.Default);

            //container.RegisterType<IEmployeeDetailsService, EmployeeDetailsService>();
            //container.RegisterType<IEmployeeDetailsRepository, EmployeeDetailsRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}