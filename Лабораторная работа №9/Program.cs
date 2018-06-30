using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛабораторнаяРабота9
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            

            Car car = new Car();
            car.Power = 150;
            car.BodyType = BodyTypes.Hatchback;

            Train train = new Train();
            Express express = new Express();

            Console.WriteLine(car.MaxSpeed);
            Console.WriteLine(train.MaxSpeed);
            Console.WriteLine(express.MaxSpeed);
        }
    }
}
