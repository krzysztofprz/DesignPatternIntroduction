using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Subject //in real example it would be Stock
    {
        private string _symbol;
        private double _price;
        private List<Observer> _invenstors = new List<Observer>();

        public Subject(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Attach(Observer observer)
        {
            _invenstors.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _invenstors.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in _invenstors)
            {
                observer.Update(this);
            }
            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if(_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}
