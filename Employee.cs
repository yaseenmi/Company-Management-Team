using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2___Project1
{
    public class Employee
    {
        public string EmployeeName;
        public decimal EmployeeSalary;
        public int EmployeeAge;
        public Position Position;
        public    List<Review_> Re = new List<Review_>();
        public Employee(string EmployeeName, decimal EmployeeSalary, int EmployeeAge, Position Position)
        {
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeAge;
            this.EmployeeAge = EmployeeAge;
            this.Position = Position;
        }
    }
}