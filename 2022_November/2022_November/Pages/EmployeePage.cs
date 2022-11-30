//using _2022_November.Utilities;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _2022_November.Pages
{
    public class EmployeePage : CommonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            // create a new Employee record in the Employee module
            Console.WriteLine("Create a new Employee record in the Employee module");
            // find and click on Create button
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"container\"]/h2", 2);
            // enter valid name in Name textbox
            driver.FindElement(By.Id("Name")).SendKeys("Jerry Smith");
            // enter valid Username
            driver.FindElement(By.Id("Username")).SendKeys("jjsmith");
            // enter Contact 
            driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]")).SendKeys("my brother");
            // enter Password
            driver.FindElement(By.Id("Password")).SendKeys("Asdf5678(");
            // retype Password
            driver.FindElement(By.Id("RetypePassword")).SendKeys("Asdf5678(");
            // enter Vehicle
            //IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input")).SendKeys("truck");
            // send tab key to scroll the screen, revealing and placing the cursor/focus in the Groups box
            //vehicleTextbox.SendKeys(Keys.Tab + Keys.Enter);
            //vehicleTextbox.SendKeys(Keys.Enter);

            // unable to find solution to pressing the tab key so am clicking down arrow of scroll bar twice
            //driver.FindElement(By.XPath("/html"))
            //IWebElement inputField = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            //inputField.SendKeys(Keys.Tab);
            // click in the Groups box
            //driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]")).Click();

            // enter 't' in Groups box to show groups beginning with t in drop-down, then select 1st item

            // *********** failing on the following line
            //driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]")).SendKeys("t");
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[1]")).Click();
            // send tab key again to reveal and possibly scroll screen to focus on the Save button
            //IWebElement groupsBox = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[1]"));
            //groupsBox.SendKeys(Keys.Tab);
            // click the Save button
            //driver.FindElement(By.Id("SaveButton")).Click();
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // check if new employee record was created successfully by sending single Tab, clicking Back to List and navigating to last page
            // tab to the Back to List link
            saveButton.SendKeys(Keys.Tab);
            Thread.Sleep(1000);
            // click on the Focused element -- Back to List
            IWebElement backToListLink = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToListLink.Click();
            Thread.Sleep(2500);
            // click on Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);
            IWebElement lastRowUsername = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(lastRowUsername.Text == "jjsmith", "Actual Username and expected Username do not match");
        }

        public void EditEmployee(IWebDriver driver)
        {
            Console.WriteLine("Edit the new Employee record");

            // click on Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // verify Username in last row is the correct record to edit
            IWebElement lastRowUsername = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(lastRowUsername.Text == "jjsmith", "Edit aborted because actual Username and expected Username do not match");

            // find edit button in last row
            // replace digit in tr[] with last() to get last row in table
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();
            //*[@id="usersGrid"]/div[3]/table/tbody/tr[6]/td[3]/a[1]

            // edit the Username in the Username textbox, clearing the value before entering the new value
            IWebElement userNameTextbox = driver.FindElement(By.Id("Username"));
            userNameTextbox.Clear();
            userNameTextbox.SendKeys("jjsmithed");

            // send 8 tabs to place the focus on the Save button
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            //userNameTextbox.SendKeys(Keys.Tab);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // click on the Back to List link
            IWebElement backToListLink = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToListLink.Click();
            Thread.Sleep(2500);
            // click on Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);
            IWebElement lastRowEditedUsername = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(lastRowEditedUsername.Text == "jjsmithed", "Actual edited Username and expected Username do not match");
        }

        public void DeleteEmployee(IWebDriver driver)
        {
            Console.WriteLine("Delete the new, edited Employee record");

            // click on Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // verify Username in last row is the correct record to edit
            IWebElement lastRowUsername = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(lastRowUsername.Text == "jjsmithed", "Edit aborted because actual edited Username and expected edited Username do not match");

            // find delete button in last row
            // replace digit in tr[] with last() to get last row in table
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[6]/td[3]/a[2]")).Click();
            //*[@id="usersGrid"]/div[3]/table/tbody/tr[6]/td[3]/a[2]

            Wait.WaitForAlertBoxToBePresent(driver, 3);

            // click OK button in pop-up confirmation window - record is deleted and user remains on last page
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            if (driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]")).Text == "jjsmithed")
            {
                Console.WriteLine("Edited Employee record wasn't deleted successfully");
            }
            else
            {
                Console.WriteLine("Edited Employee record was deleted successfully");
            }
        }

    }
}
