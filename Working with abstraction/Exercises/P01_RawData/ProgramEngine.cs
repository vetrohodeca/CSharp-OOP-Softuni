using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RawData
{
    class ProgramEngine
    {
        private readonly List<Car> cars;
        private readonly List<Tire> carTires;

        public ProgramEngine()
        {
            this.cars = new List<Car>();
            this.carTires = new List<Tire>();
        }
        public void Run()
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
              
               for(int j=5;j<13;j+=2)
                {
                    double currrentPressure = double.Parse(parameters[j]);
                    int currentAge = int.Parse(parameters[j+1]);
                    Tire currentTire = CreateTire( currentAge,  currrentPressure);
                    this.carTires.Add(currentTire);
                }
                Engine engine = this.CreateEngine(engineSpeed, enginePower);
                Cargo cargo = this.CreateCargo(cargoWeight, cargoType);
                List<Tire> tires = new List<Tire>();
                Car car = this.CreateCar(model, engine, cargo, this.carTires);
                this.cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = this.cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = this.cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
        private Engine CreateEngine(int speed, int power)
        {
            Engine engine = new Engine(speed, power);
            return engine;
        }
        private Cargo CreateCargo(int weight, string type)
        {
            Cargo cargo = new Cargo(weight, type);
            return cargo;
        }
        private Tire CreateTire(int age, double pressure)
        {
            Tire tire = new Tire(age, pressure);
            return tire;
        }
        private Car CreateCar(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Car car = new Car(model, engine, cargo, tires.ToArray());
            return car;
        }
    }
}
