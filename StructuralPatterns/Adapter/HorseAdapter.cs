using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class HorseAdapter : ICar
    {
        private IHorse _horse;

        public HorseAdapter(IHorse horse)
        {
            _horse = horse;
        }

        public void Move()
        {
            _horse.Move();
        }

        public void Refueling()
        {
            _horse.Eating();
        }
    }
}
