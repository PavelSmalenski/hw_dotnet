using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.GenericRepo.Models
{
    /// <summary>
    /// Motorcycle item representation
    /// </summary>
    class Motorcycle : IRepositoryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }

        public Motorcycle(string name, string model, int year, int odometer)
        {
            Id = Guid.NewGuid();
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }

        public Motorcycle(Guid id, string name, string model, int year, int odometer)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }

        public void Update(IRepositoryItem item)
        {
            Motorcycle motorcycleItem = item as Motorcycle;
            if (motorcycleItem is null)
            {
                Console.WriteLine("Items type mismatch!");
                return;
            }

            Id = motorcycleItem.Id;
            Name = motorcycleItem.Name;
            Model = motorcycleItem.Model;
            Year = motorcycleItem.Year;
            Odometer = motorcycleItem.Odometer;
        }

        public override string ToString()
        {
            return $"Motorcycle - Id:{Id}; Name:{Name}; Model:{Model}; Year:{Year}; Odometer:{Odometer}";
        }
    }
}
