using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class FullyRentedState : IAutomatState
    {
        private Automat _automat;

        public FullyRentedState(Automat automat)
        {
            _automat = automat;
        }

        public String GotApplication() { return "Sorry, we're fully rented."; }

        public String CheckApplication() { return "Sorry, we're fully rented."; }

        public String RentApartment() { return "Sorry, we're fully rented."; }

        public String DispenseKeys() { return "Sorry, we're fully rented."; }
    }
}
