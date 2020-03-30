using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Cars
{
    public class Car: Vehicle 
    { 
        public Car(int hp, double fuel): base (hp, fuel)
        {
            

        }
        private const double DefaultFuelConsumption = 3;
        public override double FuelConsumption => DefaultFuelConsumption; 
    }
}