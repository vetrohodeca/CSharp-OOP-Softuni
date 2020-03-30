using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Motorcycles
{
    public class RaceMotorcycle:Motorcycle
    {
        public RaceMotorcycle(int hp, double fuel): base(hp, fuel)
        {

        }
        private const double DefaultFuelConsumption = 8;
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
