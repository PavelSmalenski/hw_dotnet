using HW03.Catalog.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Catalog.Model
{
    class StoredMusic : StorageItem, IPlayable  
    {
        public int Length { get; set; }
        public string Singer { get; set; }

        public StoredMusic(int length, string singer, string name, string code, string category, int size) : base(name, code, category, size)
        {
            Length = length;
            Singer = singer;
        }

        public void Play()
        {
            throw new NotImplementedException("Oops! Music doesn't have it yet!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Length}-{Singer}-{Name}-{Code}-{Category}-{Size}");
        }
    }
}
