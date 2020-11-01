using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class GotApplicationState : IAutomatState
    {
        private Automat _automat;
        private readonly Random _random;

        public GotApplicationState(Automat automat)
        {
            _automat = automat;
            _random = new Random(System.DateTime.Now.Millisecond);
        }

        public String GotApplication() { return "We already got your application."; }

        public String CheckApplication()
        {
            var yesNo = _random.Next() % 10;

            if (yesNo > 4 && _automat.Count > 0)
            {
                _automat.SetState(_automat.GetApartmentRentedState());
                return "Congratulations, you were approved.";
            }
            else
            {
                _automat.SetState(_automat.GetWaitingState());
                return "Sorry, you were not approved.";
            }
        }

        public String RentApartment() { return "You must have your application checked."; }

        public String DispenseKeys() { return "You must have your application checked."; }
    }
}
