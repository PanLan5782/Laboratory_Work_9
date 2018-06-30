using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛабораторнаяРабота9
{
    class Vehicle
    {
        private double _power;

        public double Power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
            }
        }

        protected double _maxSpeed;
        public double MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
        }

    }
}
