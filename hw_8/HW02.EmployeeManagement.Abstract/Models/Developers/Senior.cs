using DataStorage;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.EmployeeManagement.Abstract.Models.Developers
{
    class Senior : Employee
    {
        public Senior(string firstName, string lastName, int experienceYears, string gitURL) : base(firstName, lastName, experienceYears, gitURL)
        {
            AddResponsibility(EmployeeConstants.Responsiblities.Senior);
        }

        public override int Salary
        {
            get
            {
                return EmployeeConstants.Salary.BaseSalary * EmployeeConstants.Salary.SeniorCoefficient + EmployeeConstants.Salary.SeniorBonus;
            }
        }
    }
}
