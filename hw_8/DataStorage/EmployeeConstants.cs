using System;

namespace DataStorage
{
    public static class EmployeeConstants
    {
        public static class Responsiblities
        {
            public static readonly string[] Common = { "B2 English" };

            // Note 1: not sure - looks like here it's a combination of skills & responsibilities
            // Note 2: tried searching for ".NET <level> skills/responsibilities" and mostly got Q for interviews with some vague skills requirements. Below is some 'general' poins I've gathered from there
            public static readonly string[] Junior = { "C# basics", ".NET platform & frameworks basics", "SQL administration and usage", "Unit-testing" };
            public static readonly string[] Middle = { "Programming patterns", "Web technologies and protocols", "Asynchroneous programming", "Memory management" };
            public static readonly string[] Senior = { "Performance management", "Deployment", "Microservices", "Azure" };
            public static readonly string[] TechLead = { "Agile/Scrum", "Strong soft skills", "Metrics management", "Requirements management" };
            public static readonly string[] Architect = { "Product strategy management/SDLC", "Team mentorship", "Product design and management tools", "Specifications management" };
        }

        public static class Salary
        {
            public const int BaseSalary = 500;
            public const int BaseBonus = 0;
            public const int BaseCoefficient = 1;

            public const int JuniorBonus = BaseBonus;
            public const int JuniorCoefficient = BaseCoefficient;

            public const int MiddleBonus = BaseBonus;
            public const int MiddleCoefficient = 3;

            public const int SeniorBonus = 300;
            public const int SeniorCoefficient = 5;

            public const int TechLeadBonus = 500;
            public const int TechLeadCoefficient = 8;

            public const int ArchitectBonus = 1000;
            public const int ArchitectCoefficient = 12;
        }
    }
}
