using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento<T> where T : ICloneable
    {
        private T StateObject { get; set; }

        public T GetState()
        {
            return StateObject;
        }

        public void SetState(T stateObject)
        {
            StateObject = (T)stateObject.Clone();
        }
    }
}
