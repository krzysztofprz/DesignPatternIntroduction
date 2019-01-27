using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Observer : IObserver
    {
        private string _name;
        private Subject _subject;

        public Observer(string name)
        {
            this._name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, subject.Symbol, subject.Price);
        }

        public Subject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
