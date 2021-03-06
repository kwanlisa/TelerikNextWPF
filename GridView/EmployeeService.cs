﻿using System.Collections.ObjectModel;

namespace GridView
{
    internal class EmployeeService
    {
        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees =
                new ObservableCollection<Employee>();
            var employee = new Employee();
            employee.FirstName = "Maria";
            employee.LastName = "Anders";
            employee.IsMarried = true;
            employee.Age = 24;
            employees.Add(employee);
            employee = new Employee();
            employee.FirstName = "Ana";
            employee.LastName = "Trujillo";
            employee.IsMarried = true;
            employee.Age = 44;
            employees.Add(employee);
            employee = new Employee();
            employee.FirstName = "Antonio";
            employee.LastName = "Moreno";
            employee.IsMarried = true;
            employee.Age = 33;
            employees.Add(employee);
            employee = new Employee();
            employee.FirstName = "Thomas";
            employee.LastName = "Hardy";
            employee.IsMarried = false;
            employee.Age = 13;
            employees.Add(employee);

            return employees;
        }
    }
}