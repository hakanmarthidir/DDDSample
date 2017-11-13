using Autofac;
using Autofac.Integration.Mvc;
using DDDSample.ApplicationLayer.Services;
using DDDSample.DomainLayer.Survey;
using DDDSample.InfrastructureLayer.Context;
using DDDSample.InfrastructureLayer.Repositories;
using DDDSample.InfrastructureLayer.Uow;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DDDSample.PresentationLayer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            builder.RegisterType<SurveyContext>().As<DbContext>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork<SurveyContext>>().InstancePerRequest();
            builder.RegisterType<SurveyService>().As<ISurveyService>().InstancePerRequest();
            builder.RegisterType<GenericRepository<Survey, Guid>>().As<InfrastructureLayer.Repositories.IGenericRepository<Survey, Guid>>().InstancePerRequest();
            //builder.RegisterType<GenericRepository<SurveyQuestion, Guid>>().As<InfrastructureLayer.Repositories.IGenericRepository<SurveyQuestion, Guid>>().InstancePerRequest();
            // builder.RegisterType<GenericRepository<SurveyQuestionOption, Guid>>().As<InfrastructureLayer.Repositories.IGenericRepository<SurveyQuestionOption, Guid>>().InstancePerRequest();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
