using HW01.GenericRepo.Controls;
using HW01.GenericRepo.Models;
using System;

namespace HW01.GenericRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            var staticRepo = new RepositoryStatic<Motorcycle>();
            InitRepository(staticRepo);

            TestRepository(staticRepo);
        }

        public static void InitRepository(IRepository<Motorcycle> repo)
        {
            repo.Add(new Motorcycle("Name1", "Model1", 2001, 100));
            repo.Add(new Motorcycle("Name2", "Model2", 2002, 200));
            repo.Add(new Motorcycle("Name3", "Model3", 2003, 300));
            repo.Add(new Motorcycle("Name4", "Model4", 2004, 400));
            repo.Add(new Motorcycle("Name5", "Model5", 2005, 500));
        }

        public static void TestRepository(IRepository<Motorcycle> repo)
        {
            // Read
            Motorcycle existingMotorcycle;
            try
            {
                existingMotorcycle = repo.GetAll()[0];
                Console.WriteLine($"READ - item: {existingMotorcycle}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Repository should have at least 1 item for testing!");
                return;
            }

            // Update
            string oldName = existingMotorcycle.Name;
            existingMotorcycle.Name = "New Name";

            repo.Update(existingMotorcycle);
            var repoMotorcycle = repo.GetById(existingMotorcycle.Id);
            Console.WriteLine($"UPDATE - item BEFORE: {repoMotorcycle}");

            existingMotorcycle.Name = oldName;
            repo.Update(existingMotorcycle);
            repoMotorcycle = repo.GetById(existingMotorcycle.Id);
            Console.WriteLine($"UPDATE - item AFTER: {repoMotorcycle}");

            // Delete - Add
            repo.Delete(existingMotorcycle.Id);
            Console.WriteLine($"DELETE - repo after delete:");
            foreach (var motorcycle in repo.GetAll())
            {
                Console.WriteLine(motorcycle);
            }

            repo.Add(existingMotorcycle);
            Console.WriteLine($"ADD - repo after add:");
            foreach (var motorcycle in repo.GetAll())
            {
                Console.WriteLine(motorcycle);
            }
        }
    }
}
