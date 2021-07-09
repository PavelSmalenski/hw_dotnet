using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Catalog.Model
{
    class StorageItem
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public int Size { get; set; }

        public StorageItem(string name, string code, string category, int size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name}-{Code}-{Category}-{Size}");
        }
    }
}
