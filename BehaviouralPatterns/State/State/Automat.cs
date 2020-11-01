using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Automat : IAutomat
    {
        private IAutomatState _waitingState;
        private IAutomatState _gotApplicationState;
        private IAutomatState _apartmentRentedState;
        private IAutomatState _fullyRentedState;
        private IAutomatState _state;
        private Int32 _count;

        public Automat(Int32 n)
        {
            _count = n;
            _waitingState = new WaitingState(this);
            _gotApplicationState = new GotApplicationState(this);
            _apartmentRentedState = new ApartmentRentedState(this);
            _fullyRentedState = new FullyRentedState(this);
            _state = _waitingState;
        }

        public void GotApplication()
        {
            Console.WriteLine(_state.GotApplication());
        }

        public void CheckApplication()
        {
            Console.WriteLine(_state.CheckApplication());
        }

        public void RentApartment()
        {
            Console.WriteLine(_state.RentApartment());
            Console.WriteLine(_state.DispenseKeys());
        }

        public void SetState(IAutomatState s) { _state = s; }

        public IAutomatState GetWaitingState() { return _waitingState; }

        public IAutomatState GetGotApplicationState() { return _gotApplicationState; }

        public IAutomatState GetApartmentRentedState() { return _apartmentRentedState; }

        public IAutomatState GetFullyRentedState() { return _fullyRentedState; }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
    }
}
