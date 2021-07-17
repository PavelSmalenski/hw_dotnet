using DataStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.EmployeeManagement.Models.Developers
{
    class Architect : Employee
    {
        public Architect(string firstName, string lastName, int experienceYears, string gitURL) : base(firstName, lastName, experienceYears, gitURL)
        {
            AddResponsibility(EmployeeConstants.Responsiblities.Architect);
        }

        public override int Salary
        {
            get
            {
                return EmployeeConstants.Salary.BaseSalary * EmployeeConstants.Salary.ArchitectCoefficient + EmployeeConstants.Salary.ArchitectBonus;
            }
        }
    }
}
