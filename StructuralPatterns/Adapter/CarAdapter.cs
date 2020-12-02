using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CarAdapter : IHorse
    {
        private ICar _car;

        public CarAdapter(ICar car)
        {
            _car = car;
        }

        public void Eating()
        {
            _car.Refueling();
        }

        public void Move()
        {
            _car.Move();
        }
    }
}
