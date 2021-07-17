using HW01.EmployeeManagement.Models.Developers;
using System;

namespace HW01.EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeManagement = new Controls.EmployeeManagement("Company_Name");

            employeeManagement.AddEmployee(new Junior("Name1", "Surname1", 1, "https://git.com/someGit1"));
            employeeManagement.AddEmployee(new Middle("Name2", "Surname2", 1, "https://git.com/someGit2"));
            employeeManagement.AddEmployee(new Senior("Name3", "Surname3", 1, "https://git.com/someGit3"));
            employeeManagement.AddEmployee(new TechLead("Name4", "Surname4", 1, "https://git.com/someGit4"));
            employeeManagement.AddEmployee(new Architect("Name5", "Surname5", 1, "https://git.com/someGit5"));

            employeeManagement.PrintEmployee();
        }
    }
}
