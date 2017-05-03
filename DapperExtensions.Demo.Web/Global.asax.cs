using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Autofac;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
using System.Reflection;
using DapperExtensions.Demo.Web.App_Start;
using HY.Freamework.Demo;
namespace DapperExtensions.Demo.Web
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            RegisterManage.Register(builder);
            Helper.IC = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Helper.IC));

            // 在应用程序启动时运行的代码
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        
        void Application_EndRequest(object sender, EventArgs e)
        {
            Helper.DisposePerHttpRequestDBSession();
        }
    }
}