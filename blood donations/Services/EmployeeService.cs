using blood_donations.Entities;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;

namespace blood_donations.Servies
{
    public class EmployeeService
    {
       public static List<Employee> Employees = new List<Employee>()
    {
        new Employee{Id="12",FirstNameEmployee="shevi",LastNameEmployee="kukis",employeeRank=EmployeeRank.Manager,
            EmailEmployee="tgtr",EmployeeId="43423"} };


        public List<Employee> GetServies()
        {
            return Employees;
        }
        public Employee GetServiesById(string id)
        {
            return Employees.FirstOrDefault(e => e.Id == id);
        }
        public ActionResult<bool> PostServies(Employee e)
        {
            Employees.Add(e);
            return true;
        }
        public ActionResult<bool> PutServies(string id,Employee employee)
        {
            foreach (Employee e in Employees)
            {
                if (e.Id ==id)
                {
                    e.Id = employee.Id;
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
        public ActionResult<bool> DeleteServies(string id)
        {
            return Employees.Remove(Employees.FirstOrDefault(e => e.Id == id));
        }
    }
}
