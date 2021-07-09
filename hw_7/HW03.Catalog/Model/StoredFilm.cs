using HW03.Catalog.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Catalog.Model
{
    class StoredFilm : StorageItem, IPlayable
    {
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }

        public StoredFilm(string director, string mainActor, string mainActress, string name, string code, string category, int size) : base(name, code, category, size)
        {
            Director = director;
            MainActor = mainActor;
            MainActress = mainActress;
        }

        public void Play()
        {
            throw new NotImplementedException("Oops! Film doesn't have it yet!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Director}-{MainActor}-{MainActress}-{Name}-{Code}-{Category}-{Size}");
        }
    }
}
