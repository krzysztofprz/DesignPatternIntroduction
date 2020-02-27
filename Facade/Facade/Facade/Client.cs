using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}
