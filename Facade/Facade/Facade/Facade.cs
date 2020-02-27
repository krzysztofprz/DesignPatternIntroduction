using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = $"Facade initializes subsystems {nameof(Subsystem1)} and {nameof(Subsystem2)} :\n";
            result += _subsystem1.Operation1();
            result += _subsystem2.Operation1();

            return result;
        }
    }
}
