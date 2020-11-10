using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayRollThreading;
using System.Collections.Generic;

namespace EmployeePayRollThreadingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {



            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();             //List of EmployeeDetails 


            //Add Employee To Payroll without Using Thread

            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Banner", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "clark", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Mike", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Jason", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Patrick", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Maria", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Steve", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100));//, TaxablePay: 2, Tax: 3, Country: "India"));


            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();       //EmployeePayRollOperation



            //Implementation Without Thread

            DateTime startDateTime = DateTime.Now;
            employeePayRollOperation.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            Console.WriteLine();



            //Implementation With Using Thread

            DateTime startDateTimeThread = DateTime.Now;
            employeePayRollOperation.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (stopDateTimeThread - startDateTimeThread));

        }
    }
}
