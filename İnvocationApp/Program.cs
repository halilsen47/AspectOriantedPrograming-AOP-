using Autofac;
using Castle.Components.DictionaryAdapter;
using Castle.DynamicProxy;
using Entities;
using System;

namespace İnvocationApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DefaultModule());
            
            var container = builder.Build();
            var willBeIntercepted = container.Resolve<IEmployee>();

            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "ak"
            };

            willBeIntercepted.update(emp1.Id,emp1.FirstName,emp1.LastName);


        }
    }

}