using DataStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.EmployeeManagement.Models
{
    class Employee
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int ExperienceYears { get; private set; }
        public List<string> Responsibilities { get; private set; } = new List<string>();
        public List<string> Technologies { get; private set; } = new List<string>();
        public string GitURL { get; private set; }
        public virtual int Salary
        {
            get
            {
                return EmployeeConstants.Salary.BaseSalary * EmployeeConstants.Salary.BaseCoefficient + EmployeeConstants.Salary.BaseBonus;
            }
        }

        public Employee(string firstName, string lastName, int experienceYears, string gitURL)
        {
            FirstName = firstName;
            LastName = lastName;
            ExperienceYears = experienceYears;
            GitURL = gitURL;
            AddResponsibility(EmployeeConstants.Responsiblities.Common);
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
            return $"Full Name: {FirstName} {LastName}, Experience: {ExperienceYears}, Title: {this.GetType()}, Salary: {Salary}, GitHub: {GitURL}"
        }
    }
}
