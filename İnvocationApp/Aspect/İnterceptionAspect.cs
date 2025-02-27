using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnvocationApp.Aspect
{
    public class İnterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0}",invocation.Method);
            Console.WriteLine($"{"Method Name",-20} : {invocation.Method.Name}");
            Console.WriteLine($"{"Target Type",-20} : {invocation.TargetType}");
            Console.WriteLine($"{"İnvocation Target",-20} : {invocation.InvocationTarget}");
            Console.WriteLine($"{"Proxy",-20} : {invocation.Proxy}");
            Console.WriteLine("Arguments");
            foreach(var argument in invocation.Arguments)
            {
                Console.WriteLine($"\t{"Type",-12} : " +
                    $"${argument.GetType()} | {argument}");
            }
            Console.WriteLine();
            invocation.Proceed();
            Console.WriteLine("After {0}",invocation.Method);

        }
    }
}
