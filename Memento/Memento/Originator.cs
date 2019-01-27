using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Originator<T> where T : ICloneable
    {
        private T StateObject { get; set; }

        public Memento<T> CreateMemento()
        {
            Memento<T> m = new Memento<T>();
            m.SetState(this.StateObject);
            return m;
        }

        public void RestoreMemento(Memento<T> m)
        {
            this.StateObject = m.GetState();
        }

        public void SetState(T state)
        {
            this.StateObject = state;
        }

        public void ShowState()
        {
            Console.WriteLine(this.StateObject.ToString());
        }

    }
}
