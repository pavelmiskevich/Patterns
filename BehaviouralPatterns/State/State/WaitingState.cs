using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class WaitingState : IAutomatState
    {
        private Automat _automat;

        public WaitingState(Automat automat)
        {
            _automat = automat;
        }

        public String GotApplication()
        {
            _automat.SetState(_automat.GetGotApplicationState());
            return "Thanks for the application.";
        }

        public String CheckApplication() { return "You have to submit an application."; }

        public String RentApartment() { return "You have to submit an application."; }

        public String DispenseKeys() { return "You have to submit an application."; }
    }
}
