using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.İnterceptors
{

    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Method |
        AttributeTargets.Assembly,
        AllowMultiple = true,
        Inherited = true)]
    public abstract class MethodİnterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int pireority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {
        
        }

    }
}
