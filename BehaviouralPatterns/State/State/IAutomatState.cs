using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IAutomatState
    {
        String GotApplication();
        String CheckApplication();
        String RentApartment();
        String DispenseKeys();
    }
}
