using Microsoft.VisualBasic;

namespace CastleDynamicProxyFirstApp
{
    public interface IMyClass
    {
        void MyMethod();
    }
    public class MyClass : IMyClass
    {

        [MyInterceptorAspect(pireority = 1)]
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod Body..");
        }

    }
}