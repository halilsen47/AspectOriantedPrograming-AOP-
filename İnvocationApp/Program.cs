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
                .CreateClassProxy<Employee>(new İnterceptionAspect());
            
            aspect.Add(1, "John", "Doe");
        }
    }

}