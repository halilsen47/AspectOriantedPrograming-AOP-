using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.İnterceptors
{
    public class AspectİntercepterSelector
        : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes =
                type.GetCustomAttributes<MethodİnterceptionBaseAttribute>(true)
                .ToList();

            var methodAttributes =
                type.GetMethod(method.Name)
                .GetCustomAttributes<MethodİnterceptionBaseAttribute>(true);

            if(methodAttributes != null)
                classAttributes.AddRange(methodAttributes);

            return classAttributes
                .OrderBy(x => x.pireority)
                .ToArray();


        }
    }
}
