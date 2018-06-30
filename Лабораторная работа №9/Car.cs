using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛабораторнаяРабота9
{
    class Car:Vehicle
    {
        public Car()
        {
            _maxSpeed = 200;
        }

        public BodyTypes BodyType { get; set; }
    }

    enum BodyTypes
    {
        Hatchback,
        Sedan,
        Universal
    }
}
