using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Cargo
    {
        public Cargo( int cargoWeight, string cargoType)
        {
            this.Type = cargoType;
            this.Weight = cargoWeight;
        }

        public int Weight { get; }
        public string Type { get; }
    }
}
