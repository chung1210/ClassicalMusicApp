using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using System.Reflection;
using App.Data.Infrastructure;
using App.Service;
using System.Web.Mvc;
using System.Web.Http;
using Autofac.Integration.Mvc;
using App.Data;
using Microsoft.AspNet.Identity;
using App.Model;
using Microsoft.Owin.Security;

using System.Web;
using Autofac.Integration.WebApi;
using App.Service.Music;
using App.Data.Repositories;

namespace App.Website.App_Start
{
    public static class AutofacConfig
    {
        public static void AutofacConfigInit()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<AppDbContext>().AsSelf().InstancePerRequest();



            // Repositories
            builder.RegisterAssemblyTypes(typeof(BaiHatRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies); ;

            // Services
            builder.RegisterAssemblyTypes(typeof(BaiHatService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest()
               .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies); ;

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

        }
    }
}