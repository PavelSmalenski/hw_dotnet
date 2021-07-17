using DataStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.EmployeeManagement.Abstract.Models.Developers
{
    class Middle : Employee
    {
        public Middle(string firstName, string lastName, int experienceYears, string gitURL) : base(firstName, lastName, experienceYears, gitURL)
        {
            AddResponsibility(EmployeeConstants.Responsiblities.Middle);
        }

        public override int Salary
        {
            get
            {
                return EmployeeConstants.Salary.BaseSalary * EmployeeConstants.Salary.MiddleCoefficient + EmployeeConstants.Salary.MiddleBonus;
            }
        }
    }
}
