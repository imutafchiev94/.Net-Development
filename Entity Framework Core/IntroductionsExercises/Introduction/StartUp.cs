using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace SoftUni
{
    
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext softUni = new SoftUniContext();

            Console.WriteLine(GetEmployeesInPeriod(softUni));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var employees = context.Employees.OrderBy(p => p.EmployeeId).Select(p => new
            {
                p.FirstName,
                p.LastName,
                p.MiddleName,
                p.JobTitle,
                p.Salary
            });

            var builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} " +
                    $"{employee.JobTitle} {employee.Salary:F2}");
            }

            return builder.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees.Select(e => new { e.FirstName, e.Salary })
                .Where(e => e.Salary > 50000).OrderBy(e => e.FirstName);

            var builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }

            return builder.ToString();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees.Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.Department,
                e.Salary
            }).Where(e => e.Department.Name == "Research and Development")
            .OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName);

            var builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} {employee.LastName} " +
                    $"from {employee.Department.Name} - ${employee.Salary:F2}");
            }

            return builder.ToString();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new Address() { AddressText = "163 Nishava Str, ent A, apt. 1", TownId = 32 };

            var Nakovemployees = context.Employees.Where(e => e.LastName == "Nakov");

            foreach (var employee in Nakovemployees)
            {
                employee.Address = address;

                
            }
            context.SaveChanges();

            var employees = context.Employees.Select(e => e.Address).OrderByDescending(e => e.AddressId);

            var builder = new StringBuilder();

            int count = 1;

            foreach (var employee in employees)
            {
                if(count <= 10)
                {
                    builder.AppendLine($"{employee.AddressText}");
                    count++;
                }
            }

            return builder.ToString();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employess = context.Employees
                .Include(e => e.Manager)
                .Include(e => e.EmployeesProjects)
                .ThenInclude(e => e.Project)
                .Where(e => e.EmployeesProjects
                .Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
                .ToList();

            var builder = new StringBuilder();

            int count = 1;

            foreach (var employee in employess)
            {
                if(count <= 10)
                {
                    builder.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");
                    foreach (var project in employee.EmployeesProjects)
                    {
                        var endDate = project.Project.EndDate;
                        if (endDate == null)
                        {
                            builder.AppendLine($"--{project.Project.Name} - {project.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - not finished");
                        }
                        else
                        {
                            builder.AppendLine($"--{project.Project.Name} - {project.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {project.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
                        }
                    }
                    count++;
                }
                else
                {
                    break;
                }

            }

            return builder.ToString();
        }

    }
}
