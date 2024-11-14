using blood_donations.Entities;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;
using System;

namespace blood_donations.Servies
{
    public class EmployeeService
    {
        public DataContext dataContext = ManagerDataContex.DataContex;

        public List<Employee> GetServies()
        {
            return dataContext.employees;
        }
        public Employee GetServiesById(int id)
        {
            for (int i = 0; i < dataContext.employees.Count; i++)
            {
                if (dataContext.employees[i].Id==id)
                    return dataContext.employees[i];
            }
            return default(Employee);
        }
        public bool PostServies(Employee e)
        {
            dataContext.employees.Add(e);
            return true;
        }
        public bool PutServies(int id,Employee employee)
        {
            foreach (Employee e in dataContext.employees)
            {
                if (e.Id ==id)
                {
                    
                    e.employeeRank = employee.employeeRank;
                    e.DateOfBegin = employee.DateOfBegin;
                    e.BirthDate = employee.BirthDate;
                    e.FirstNameEmployee = employee.FirstNameEmployee;
                    e.LastNameEmployee = employee.LastNameEmployee;
                    e.EmailEmployee = employee.EmailEmployee;
                    e.EmployeeId = employee.EmployeeId;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return dataContext.employees.Remove(dataContext.employees.FirstOrDefault(e => e.Id == id));
        }
    }
}
