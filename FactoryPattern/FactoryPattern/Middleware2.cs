using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Middleware2 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("An action from Middleware2");
        }
    }
}
