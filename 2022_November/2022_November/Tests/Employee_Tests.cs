//using _2022_November.Pages;
//using _2022_November.Utilities;
//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _2022_November.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        [Test, Order(1), Description("Check if user can create an employee record with valid data")]
        public void CreateEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if user can edit an existing employee record successfully")]
        public void EditEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user can delete an existing & edited employee record successfully")]
        public void DeleteEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }
    }
}
