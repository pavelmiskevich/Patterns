using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IAutomat
    {
        void GotApplication();
        void CheckApplication();
        void RentApartment();

        void SetState(IAutomatState s);
        IAutomatState GetWaitingState();
        IAutomatState GetGotApplicationState();
        IAutomatState GetApartmentRentedState();
        IAutomatState GetFullyRentedState();

        Int32 Count { get; set; }
    }
}
