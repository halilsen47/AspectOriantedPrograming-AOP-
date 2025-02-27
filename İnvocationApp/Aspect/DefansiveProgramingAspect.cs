using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnvocationApp.Aspect
{
    public class DefansiveProgramingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var parameters = invocation.Arguments;
            foreach (var parameter in parameters)
            {
                if (parameter.Equals(null))
                    throw new ArgumentNullException();
                Console.WriteLine("Null check has been complated for {0}",invocation.Method);
            }
        }
    }
}
