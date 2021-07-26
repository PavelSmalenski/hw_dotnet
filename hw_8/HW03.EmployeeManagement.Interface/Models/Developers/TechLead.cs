using DataStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.EmployeeManagement.Interface.Models.Developers
{
    class TechLead : IEmployee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExperienceYears { get; set; }
        public List<string> Responsibilities { get; set; } = new List<string>();
        public List<string> Technologies { get; set; } = new List<string>();
        public string GitURL { get; set; }
        public int Salary
        {
            get
            {
                return EmployeeConstants.Salary.BaseSalary * EmployeeConstants.Salary.TechLeadCoefficient + EmployeeConstants.Salary.TechLeadBonus;
            }
        }

        public TechLead(string firstName, string lastName, int experienceYears, string gitURL)
        {
            FirstName = firstName;
            LastName = lastName;
            ExperienceYears = experienceYears;
            GitURL = gitURL;
            AddResponsibility(EmployeeConstants.Responsiblities.Common);
            AddResponsibility(EmployeeConstants.Responsiblities.TechLead);
        }
        public void AddResponsibility(string responsibility)
        {
            Responsibilities.Add(responsibility);
        }

        public void AddResponsibility(IEnumerable<string> responsibility)
        {
            Responsibilities.AddRange(responsibility);
        }

        public void AddTechnology(string technology)
        {
            Technologies.Add(technology);
        }

        public void AddTechnology(IEnumerable<string> technology)
        {
            Technologies.AddRange(technology);
        }

        public override string ToString()
        {
            return $"Full Name: {FirstName} {LastName}, Experience: {ExperienceYears}, Title: {this.GetType().Name}, Salary: {Salary}, GitHub: {GitURL}";
        }
    }
}
