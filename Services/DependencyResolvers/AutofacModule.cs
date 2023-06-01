using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework;
using Services.Abstracts;
using Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DependencyResolvers
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StatisticsManager>().As<IStatisticsService>().SingleInstance();

            builder.RegisterType<EfUserRepository>().As<IUserRepository>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();

            builder.RegisterType<EfPostRepository>().As<IPostRepository>().SingleInstance();
            builder.RegisterType<PostManager>().As<IPostService>().SingleInstance();

            builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();

            builder.RegisterType<EfSubCategoryRepository>().As<ISubCategoryRepository>().SingleInstance();
            builder.RegisterType<SubCategoryManager>().As<ISubCategoryService>().SingleInstance();

            builder.RegisterType<EfMessageRepository>().As<IMessageRepository>().SingleInstance();
            builder.RegisterType<MessageManager>().As<IMessageService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
