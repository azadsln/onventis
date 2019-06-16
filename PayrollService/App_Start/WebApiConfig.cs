using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using AutoMapper;
namespace PayrollService.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            #region DI Container by Unity
            var container = new UnityContainer();
            container.RegisterType<Service.IPayment, Service.Payment>();

            var mapperConfig = AutoMapperBootStrapper.BootStrap();

            IMapper mapper = mapperConfig.CreateMapper();
            
            container.RegisterInstance(mapper);
            
            config.DependencyResolver = new UnityResolver(container);

            #endregion


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{hoursWorked}/{hourlyRate}/{countryCode}",
                defaults:new { action="get"}               
                
            );
        }
    }
}
