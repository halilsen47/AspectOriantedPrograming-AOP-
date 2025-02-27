namespace ProxyApp
{
    public class BusinessModuleProxy : IBusinessModule
    {
        private BusinessModule _realobject;

        public BusinessModuleProxy()
        {
            _realobject = new BusinessModule();
        }

        public void Method()
        {
            Console.WriteLine("Before Method..");
            _realobject.Method();
            Console.WriteLine("After Method..");
        }
    }
}