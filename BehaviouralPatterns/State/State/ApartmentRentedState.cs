using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ApartmentRentedState : IAutomatState
    {
        private Automat _automat;

        public ApartmentRentedState(Automat automat)
        {
            _automat = automat;
        }

        public String GotApplication() { return "Hang on, we'ra renting you an apartmeny."; }

        public String CheckApplication() { return "Hang on, we'ra renting you an apartmeny."; }

        public String RentApartment()
        {
            _automat.Count = _automat.Count - 1;
            return "Renting you an apartment....";
        }

        public String DispenseKeys()
        {
            if (_automat.Count <= 0)
                _automat.SetState(_automat.GetFullyRentedState());
            else
                _automat.SetState(_automat.GetWaitingState());
            return "Here are your keys!";
        }
    }
}
