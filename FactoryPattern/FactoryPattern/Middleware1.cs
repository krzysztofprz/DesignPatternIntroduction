using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Middleware1 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("Executing action from Middleware1");            
        }
    }
}
