using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class MiddlewareFactory
    {
        public IMiddleware GetMiddleware(int whichMiddlewareClassHasToBeInstantiated)
        {
            switch(whichMiddlewareClassHasToBeInstantiated)
            {
                case 1: return new Middleware1();
                case 2: return new Middleware2();
                default: return new Middleware1();
            }
        }
    }
}
