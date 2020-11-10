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
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayRollDetails)
        {
            employeePayRollDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being addded: " + employeeData.EmployeeName);
                addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added: " + employeeData.EmployeeName);
            }
            );
            Console.WriteLine(this.employeeDetails.ToString());
            Console.WriteLine(this.employeeDetails.Count);
        }


        //Add Employee To Payroll By Using Thread
        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    addEmployeePayroll(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.EmployeeName);
                }
                );
                thread.Start();
            }
            );
            Console.WriteLine(this.employeeDetails.Count);
        }


        //Addition Method
        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }



        //Counting Method
        public int EmployeeCount()
        {
            return this.employeeDetails.Count;
        }
    }
}