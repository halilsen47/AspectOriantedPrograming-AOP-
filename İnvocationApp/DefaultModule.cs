using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.İnterceptors;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnvocationApp
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var proxyopition = new ProxyGenerationOptions()
            {
                Selector = new AspectİntercepterSelector()
            };


            builder.RegisterType<Employee>()
                .As<IEmployee>()
                .EnableInterfaceInterceptors(proxyopition)
                .SingleInstance();
        }
    }
}
