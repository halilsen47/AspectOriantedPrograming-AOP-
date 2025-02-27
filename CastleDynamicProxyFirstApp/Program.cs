using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.İnterceptors;
using System;
using System.ComponentModel;



namespace CastleDynamicProxyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<MyClass>(new MyInterceptorAspect());
            aspect.MyMethod();
            Console.WriteLine("------------------------------------------------------");

            var builder = new ContainerBuilder();
            builder.RegisterType<MyClass>()
                .As<IMyClass>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectİntercepterSelector()
                })
                .InstancePerDependency();

            var container = builder.Build();
            var willbeIntercepted = container.Resolve<IMyClass>();
            willbeIntercepted.MyMethod();

            Console.Read();
        }
    }
}