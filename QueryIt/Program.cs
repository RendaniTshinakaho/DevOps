﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryIt.Datalayer;
using QueryIt.Domain;
using QueryIt.IRepository;
using QueryIt.Repository;

namespace QueryIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDb>());
            using (IRepository<Employee> employeeRepository = new SqlRepository<Employee>(new EmployeeDb()))
            {
                AddEmployees(employeeRepository);
                CountEmployees(employeeRepository);
                QueryEmployees(employeeRepository);
            }

        }

        private static void QueryEmployees(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.FindById(1);
            Console.WriteLine(employee.Name);
        }

        private static void CountEmployees(IRepository<Employee> employeeRepository)
        {
               Console.WriteLine(employeeRepository.FindAll().Count()); 
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
         employeeRepository.Add(new Employee{Name = "Scott"});
         employeeRepository.Add(new Employee{Name = "Rendani"});
            employeeRepository.Commit();
        }
    }
}
