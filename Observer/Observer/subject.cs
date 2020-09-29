using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface subject
    {
        void Attach(Oberserver observer);
        void Detach(Oberserver oberserver);

        void Notify();

        string GetState();

    }


    class SkakUnion : subject
    {
        List<Oberserver> observers = new List<Oberserver>();
        private string state;

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                Notify();
            }
        }

        public void Attach(Oberserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(Oberserver observer)
        {
            observers.Remove(observer);

        }

        public void Notify()
        {
            foreach (Oberserver o in observers)
            {
                o.Update(this);
            }

        }

        public string GetState()
        {
            return state;
        }

    }
}
