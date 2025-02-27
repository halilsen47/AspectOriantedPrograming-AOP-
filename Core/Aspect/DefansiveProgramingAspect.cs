using Castle.DynamicProxy;
using Core.İnterceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspect
{
    public class DefansiveProgramingAspect : Methodİnterception
    {
 

        public override void OnBefore(IInvocation invocation)
        {
            var parameters = invocation.Arguments;

            foreach (var parameter in parameters)
            {
                if (parameter.Equals(null))
                    OnException(invocation, new ArgumentNullException());

                Console.WriteLine("Null check has been complated for {0}", invocation.Method);
            }
        }

        public override void OnException(IInvocation invocation, Exception ex)
        {
            base.OnException(invocation, ex);
        }
    }
}
