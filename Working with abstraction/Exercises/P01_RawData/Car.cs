using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Car
    {
        private readonly Tire[] tires;
        public Car(string model, Engine engine, Cargo cargo,  Tire[] tires)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
            this.tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; }
        public Cargo Cargo { get; }

        public IReadOnlyCollection<Tire> Tires
        {
            get
            {
                return this.tires;
            }
        }


}
}
