using Microsoft.VisualBasic;

namespace CastleDynamicProxyFirstApp
{
    public class MyClass
    {

        [MyInterceptorAspect]
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod Body..");
        }

    }
}