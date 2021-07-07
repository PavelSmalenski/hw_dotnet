using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.MotorcycleCompany
{
    internal class Motorcycle
    {
        string _model;
        string _manufacturer;
        int _mileage;

        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Model
        {
            get { return _model; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    string msg = $"Empty value is not valid for Model!";
                    Console.WriteLine(msg);
                    throw new ArgumentException(msg);
                }
                else
                {
                    _model = value;
                }
            }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    string msg = $"Empty value is not valid for Manufacturer!";
                    Console.WriteLine(msg);
                    throw new ArgumentException(msg);
                }
                else
                {
                    _manufacturer = value;
                }
            }
        }
        public DateTime ManufactureDate { get; private set; } = DateTime.Now;
        public int Mileage
        {
            get { return _mileage; }
            set
            {
                if (value < 0 || value > 100)
                {
                    string msg = $"Value {value} is not valid for recently manufactured motorcycle!";
                    Console.WriteLine(msg);
                    throw new ArgumentOutOfRangeException(msg);
                }
                else
                {
                    _mileage = value;
                }
            }
        }
        public Engine MotorcycleEngine { get; private set; }

        public Motorcycle(string model, string manufacturer, int mileage, int volume, int power, Engine.EngineType engineType)
        {
            Model = model;
            Manufacturer = manufacturer;
            Mileage = mileage;

            MotorcycleEngine = new Engine(volume, power, engineType);
        }

        protected void Reset()
        {
            Console.WriteLine("Reset complete!");
        }

        public override string ToString()
        {
            return $"Мотоцикл (Производитель): “{Manufacturer}”, Модель: “{Model}”, " +
                $"Vin Number (Идентификатор): “{Id}”, Год: {ManufactureDate.Year}, " +
                $"Двигатель(Объем): {MotorcycleEngine.Volume}, Мощность: {MotorcycleEngine.Power}";
        }

        internal class Engine
        {
            public enum EngineType { Gasoline, Electric, Hybrid };

            int _volume;
            int _power;

            public int Volume
            {
                get { return _volume; }
                private set
                {
                    if (value < 125 || value > 3200)
                    {
                        string msg = $"Value {value} is not valid for engine volume!";
                        Console.WriteLine(msg);
                        throw new ArgumentOutOfRangeException(msg);
                    }
                    else
                    {
                        _volume = value;
                    }
                }
            }
            public int Power
            {
                get { return _power; }
                private set
                {
                    if (value < 50 || value > 300)
                    {
                        string msg = $"Value {value} is not valid for engine power!";
                        Console.WriteLine(msg);
                        throw new ArgumentOutOfRangeException(msg);
                    }
                    else
                    {
                        _power = value;
                    }
                }
            }
            public EngineType Type { get; private set; }

            public Engine(int volume, int power, EngineType engineType)
            {
                Volume = volume;
                Power = power;
                Type = engineType;
            }
        }
    }
}
