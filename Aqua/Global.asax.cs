using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Infrastructure.Contracts.Repo;
using AdoNet;
using AdoNet.Repo;
using Infrastructure.Contracts;

namespace Aqua
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var builder = new ContainerBuilder();


            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
           // builder.RegisterType<Context>().As<DbContext>().InstancePerRequest();
            var mContext = new Context();
            builder.RegisterGeneric(typeof(CreateRepository<>)).As(typeof(ICreateRepository<>))
                .WithParameter("context", mContext);

            builder.RegisterGeneric(typeof(ReadRepository<>)).As(typeof(IReadRepository<>))
                .WithParameter("context", mContext);

            builder.RegisterGeneric(typeof(UpdateRepository<>)).As(typeof(IUpdateRepository<>))
                .WithParameter("context", mContext);

            builder.RegisterGeneric(typeof(DeleteRepository<>)).As(typeof(IDeleteRepository<>))
                .WithParameter("context", mContext);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
