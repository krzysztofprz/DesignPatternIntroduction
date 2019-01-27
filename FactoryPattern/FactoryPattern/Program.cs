using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var middlewareFactory = new MiddlewareFactory();
            IMiddleware middleware = middlewareFactory.GetMiddleware(1);
            Console.Write("Current middleware type: {0} - ", middleware.GetType());
            middleware.DoAction();

            middleware = middlewareFactory.GetMiddleware(2);
            Console.Write("Current middleware type: {0} - ", middleware.GetType());
            middleware.DoAction();
            //middlewareFactory.GetMiddleware(2);

            Console.ReadKey();
        }
    }
}
