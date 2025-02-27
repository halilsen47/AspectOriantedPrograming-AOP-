using Castle.Components.DictionaryAdapter;
using Castle.DynamicProxy;
using Entities;
using İnvocationApp.Aspect;
using System;

namespace İnvocationApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<Employee>(
                    new DefansiveProgramingAspect(),
                    new İnterceptionAspect()
                );
            //aspect.Add(1, "John", "Doe");


            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "ak"
            };

            aspect.Add(emp1.Id,emp1.FirstName,emp1.LastName);

        }
    }

}