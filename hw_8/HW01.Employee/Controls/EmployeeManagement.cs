using HW01.EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.EmployeeManagement.Controls
{
    class EmployeeManagement
    {
        List<Employee> _employees = new List<Employee>();
        string _company;

        public Employee[] Employees
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

        public void AddEmployee(Employee employee)
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
