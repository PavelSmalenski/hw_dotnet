using HW03.Catalog.Model;
using HW03.Catalog.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace HW03.Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StorageItem> storage = new List<StorageItem>();

            storage.Add(new StoredFilm("Dir1", "Actor1", "Actress1", "Name1", "Code1", "Category1", 123));
            storage.Add(new StoredFilm("Dir2", "Actor2", "Actress2", "Name2", "Code2", "Category2", 456));
            storage.Add(new StoredFilm("Dir3", "Actor3", "Actress3", "Name3", "Code3", "Category3", 789));

            storage.Add(new StoredMusic(120, "Singer1", "Name1", "Code1", "Category1", 123));
            storage.Add(new StoredMusic(120, "Singer2", "Name2", "Code2", "Category2", 456));
            storage.Add(new StoredMusic(120, "Singer3", "Name3", "Code3", "Category3", 789));

            storage.Add(new StoredProgram("Name1", "Code1", "Category1", 123));
            storage.Add(new StoredProgram("Name2", "Code2", "Category2", 456));
            storage.Add(new StoredProgram("Name3", "Code3", "Category3", 789));

            foreach (var item in storage)
            {
                item.PrintInfo();

                if (item is IPlayable)
                {
                    try
                    {
                        ((IPlayable)item).Play();
                    }
                    catch (NotImplementedException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
