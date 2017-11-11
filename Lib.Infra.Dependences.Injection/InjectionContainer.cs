using Autofac;
using Lib.Application.Core.Interfaces;
using Lib.Application.Core.Services;
using Lib.Domain.Core.Interfaces;
using Lib.Domain.Core.Services;
using System;

namespace Lib.Infra.Dependences.Injection
{
    public class InjectionContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductAppService>().As<IProductAppService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
        }
    }
}