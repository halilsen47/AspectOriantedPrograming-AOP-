using Microsoft.VisualBasic;

namespace CastleDynamicProxyFirstApp
{
    public interface IMyClass
    {
        void MyMethod();
    }
    public class MyClass : IMyClass
    {

        [MyInterceptorAspect()]
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod Body..");
        }

    }
}