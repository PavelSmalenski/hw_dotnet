using HW03.EmployeeManagement.Interface.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.EmployeeManagement.Interface.Controls
{
    class EmployeeManagement
    {
        List<IEmployee> _employees = new List<IEmployee>();
        string _company;

        public IEmployee[] Employees
        {
            get
            {
                return _employees.ToArray();
            }
        }

        public EmployeeManagement(string company)
        {
            _company = company;
        }

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
            SortEmployee();
        }

        public void PrintEmployee()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine($"Company: {_company}, {employee}");
            }
        }

        void SortEmployee()
        {
            _employees.Sort((x, y) => x.ExperienceYears.CompareTo(y.ExperienceYears));
        }
    }
}
