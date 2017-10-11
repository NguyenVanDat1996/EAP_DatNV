﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeWebserviceREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeNew" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeNew.svc or EmployeeNew.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeNew : IEmployee
    {
        EmployeeDataDataContext data = new EmployeeDataDataContext();

        public bool AddEmployee(Employee eml)
        {
            try
            {
                data.Employees.InsertOnSubmit(eml);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool DeleteEmployee(int idE)
        {
           try
            {
                Employee employeeToDelete = (from employee in data.Employees where employee.empId == idE select employee).Single();
                data.Employees.DeleteOnSubmit(employeeToDelete);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Employee> GetProductList()
        {
           try
            {
                return (from employee in data.Employees select employee).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateEmployee(Employee eml)
        {
            Employee employeeToModify = (from employee in data.Employees where employee.empId == eml.empId select employee).Single();
            employeeToModify.Age = eml.Age;
            employeeToModify.firstName = eml.firstName;
            employeeToModify.lastName = eml.lastName;
            data.SubmitChanges();
            return true;
        }
    }
}
