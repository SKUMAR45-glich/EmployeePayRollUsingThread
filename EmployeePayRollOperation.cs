using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollThreading
{
    public class EmployeePayRollOperation
    {
        public List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();      //List of EmployeeDetails  



        //Add Employee To Payroll without Using Thread
        public void AddEmployeeToPayroll(List<EmployeeDetails> employeePayRollDetails)
        {
            employeePayRollDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being addded: " + employeeData.EmployeeName);
                addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added: " + employeeData.EmployeeName);
            }
            );
            Console.WriteLine(this.employeeDetails.ToString());
        }



        //Addition Method
        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }
    }
}