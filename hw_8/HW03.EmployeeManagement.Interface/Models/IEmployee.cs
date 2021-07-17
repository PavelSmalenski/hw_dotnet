using DataStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.EmployeeManagement.Interface.Models
{
    interface IEmployee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExperienceYears { get; set; }
        public List<string> Responsibilities { get; set; }
        public List<string> Technologies { get; set; }
        public string GitURL { get; set; }
        public int Salary { get; }

        public void AddResponsibility(string responsibility);

        public void AddResponsibility(IEnumerable<string> responsibility);

        public void AddTechnology(string technology);

        public void AddTechnology(IEnumerable<string> technology);
    }
}
