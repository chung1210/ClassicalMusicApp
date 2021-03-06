﻿using System;
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

[assembly: OwinStartup(typeof(App.Website.App_Start.Startup))]
namespace App.Website.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
            // ConfigureAuth(app);
        }
        private void ConfigAutofac(IAppBuilder app)
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //// Register your Web API controllers.
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            //builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //builder.RegisterType<AppDbContext>().AsSelf().InstancePerRequest();




            //// Repositories
            //builder.RegisterAssemblyTypes(typeof(BaiHatRepository).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces().InstancePerRequest();

            //// Services
            //builder.RegisterAssemblyTypes(typeof(BaiHatService).Assembly)
            //   .Where(t => t.Name.EndsWith("Service"))
            //   .AsImplementedInterfaces().InstancePerRequest();

            //Autofac.IContainer container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

        }
    }
}