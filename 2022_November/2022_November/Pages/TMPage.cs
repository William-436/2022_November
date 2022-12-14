//using _2022_November.Utilities;
//using NUnit.Framework;
//using OpenQA.Selenium;


namespace _2022_November.Pages
{
    public class TMPage : CommonDriver
    {
        public void CreateTime(IWebDriver driver)
        {
            // create a new Time record in the Time and Material module
            Console.WriteLine("Create a new Time record in the Time and Materials module");
            // find and click on Create New button
            //Thread.Sleep(1500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 3);
            //IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            //createNewButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
            //Thread.Sleep(500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 1);

            // find and expand TypeCode drop-down box
            //IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            //typecodeDropdown.Click();
            driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            //Thread.Sleep(500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[2]", 1);

            // find and select Time in TypeCode drop-down list
            //IWebElement timeElement = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            //timeElement.Click();
            driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]")).Click();

            // find and enter code in the Code textbox
            //IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            //codeTextbox.SendKeys("my time code");
            driver.FindElement(By.Id("Code")).SendKeys("my time code");

            // find and enter description in the Description textbox
            //IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            //descriptionTextbox.SendKeys("my time description");
            driver.FindElement(By.Id("Description")).SendKeys("my time description");

            // find and enter price in the Price per unit textbox but 1st click the overlapping tag
            //IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //overlappingTag.Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            //IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
            //priceperunitTextbox.SendKeys("13");
            driver.FindElement(By.Id("Price")).SendKeys("13");

            // find and click Save button
            //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            //saveButton.Click();
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2500);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);

            // check if new time record has been created successfully
            // find and click on the Go to the last page button
            //IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // replace digit in tr[] with last() to get last row in table
            // Example 1 & 3
            //IWebElement lastRowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //Example 3 - necessary for writing short statement in Example 3 below
            //IWebElement newTimeCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            // Example 1
            //if (lastRowCode.Text == "my time code")
            // UNABLE to get Example 2 or 3 to work due to Console.Writeline in TearDown being written before Assert Pass or Fail msg
            // Example 2
            //if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my time code")
            //{
                //Example 1
                //Console.WriteLine("Time record created successfully");
                // Example 2
                //Assert.Pass("Time record created successfully - using Assert");
            //}
            //else
            //{
                //Example 1
                //Console.WriteLine("Time record wasn't created successfully");
                // Example 2
                //Assert.Fail("Time record wasn't created successfully - using Assert");
            //}
            //Example 3
            //Assert.That(lastRowCode.Text == "my time code", "Actual time code and expected time code do not match");
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement lastRowActualCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return lastRowActualCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement lastRowActualDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return lastRowActualDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement lastRowActualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return lastRowActualPrice.Text;
        }

        public void CreateMaterial(IWebDriver driver)
        {
            // create a new Material record in the Time and Material module
            Console.WriteLine("Create a new Material record in the Time and Materials module");

            // Find and click on Create New button
            //Thread.Sleep(1500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 3);
            //IWebElement createNewButton2 = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            //createNewButton2.Click();
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
            //Thread.Sleep(500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 1);

            // expand TypeCode drop-down box
            //IWebElement typecode2Dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            //typecode2Dropdown.Click();
            driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            //Thread.Sleep(500);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"TypeCode_option_selected\"]", 1);

            // select Material in drop-down list
            //IWebElement materialElement = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
            //materialElement.Click();
            driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));

            // find and enter code in the Code textbox
            //IWebElement code2Textbox = driver.FindElement(By.Id("Code"));
            //code2Textbox.SendKeys("my material code");
            driver.FindElement(By.Id("Code")).SendKeys("my material code");

            // find and enter description in the Description textbox
            //IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            //descriptionTextbox.SendKeys("my material description");
            driver.FindElement(By.Id("Description")).SendKeys("my material description");

            // find and enter price in the Price per unit textbox but 1st click the overlapping tag
            //IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //overlappingTag.Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

            //IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
            //priceperunitTextbox.SendKeys("1333");
            driver.FindElement(By.Id("Price")).SendKeys("1333");

            // find and click Save button
            //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            //saveButton.Click();
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);

            // check if new material record has been created successfully by 1st click on last page button
            //IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // replace digit in [] with last() to get last row in table
            //IWebElement lastrowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement lastRowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //if (lastrowCode.Text == "my material code")
            //if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my material code")
            //{
            //    //Console.WriteLine("Material record created successfully");
            //    Assert.Pass("Material record created successfully");
            //}
            //else
            //{
            //    //Console.WriteLine("Material record wasn't created successfully");
            //    Assert.Fail("Material record wasn't created successfully");
            //}
            Assert.That(lastRowCode.Text == "my material code", "Actual material code and expected material code do not match");
        }
        public void EditTime(IWebDriver driver, string ExistingCode, string NewCode)
        {
            Console.WriteLine("Edit Time record");
            Thread.Sleep(2000);

            // find and click on the Go to the last page button
            //IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // verify code in last row is the correct record to edit
            IWebElement lastRowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //var failMsg = string.Format("Edit aborted because time code in last row {lastRowCode} does not match expected code of {ExistingCode}");
            //Assert.That(lastRowCode.Text == ExistingCode, "Edit ABORTED because time code in last row does not match expected time code ");
            if (lastRowCode.Text == ExistingCode)
            {
                Console.Write("Found correct record to edit");
            }
            else
            {
                //string lastRowCodeText = lastRowCode.Text;
                string lastRowCodeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text;
                Console.Write($"Edit ABORTED - time code in last row -{lastRowCodeText}- does not match expected code -{ExistingCode}");
                CloseTestRun();
                //driver.Quit();
            }

            // find edit button in last row
            // replace digit in tr[] with last() to get last row in table
            //IWebElement lasteditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            //lasteditButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            // edit the code in the Code textbox, clearing the value before entering the new value
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys(NewCode);

            // find and click Save button -- control will go to 1st page
            //IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
            //saveButton2.Click();
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement lastRowEditedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return lastRowEditedCode.Text;
        }

        public void EditMaterial(IWebDriver driver)
        {
            // edit my Material record and verify the edited value
            Console.WriteLine("Edit Material record");
            Thread.Sleep(2000);

            // find and click on the Go to the last page button
            //IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton.Click();

            //*[@id="tmsGrid"]/div[4]/a[4]/span
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            //*[@id="tmsGrid"]/div[4]/a[4]
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")).Click();
            Thread.Sleep(2000);

            // verify code in last row is the correct record to edit
            IWebElement lastRowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastRowCode.Text == "my material code", "Edit aborted because material code in last row does not match expected material code");

            // wait for Edit button to be clickable
            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 3);

            // find edit button in last row
            // replace digit in tr[] with last() to get last row in table
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            // edit the code in the Code textbox, clearing the value before entering the new value
            IWebElement codeTextbox2 = driver.FindElement(By.Id("Code"));
            codeTextbox2.Clear();
            codeTextbox2.SendKeys("my edited mtl code");

            // find and click Save button -- control will go to 1st page
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            // check if edited material record has been updated successfully
            // find and click on the Go to the last page button
            //Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]", 2);

            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]")).Click();
            Thread.Sleep(2000);

            // replace digit in tr[] with last() to get last row in table
            
            if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited mtl code")
            {
                Console.WriteLine("Material record was edited successfully");
            }
            else
            {
                Console.WriteLine("Material record wasn't edited successfully");
            }
        }
        public void DeleteTime(IWebDriver driver, string ExistingCode)
        {
            Console.WriteLine("Delete Time record");
            Thread.Sleep(2000);
            // find and click on the Go to the last page button
            //IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // verify code in last row is the correct record to delete
            IWebElement lastRowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Assert.That(lastRowCode.Text == ExistingCode, "Delete ABORTED because time code in last row does not match expected time code");
            if (lastRowCode.Text == ExistingCode)
            {
                Console.Write("Found correct record to delete");
            }
            else
            {
                string lastRowCodeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text;
                Console.Write($"Delete ABORTED - time code in last row -{lastRowCodeText}- does not match expected code -{ExistingCode}");
                CloseTestRun();
                //driver.Quit();
            }

            // find and click Delete button in last row by replacing digit in tr[] with last()
            //IWebElement lastdeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            //lastdeleteButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            //Thread.Sleep(3000);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "", 1);
            Wait.WaitForAlertBoxToBePresent(driver, 3);

            // click OK button in pop-up confirmation window - item is deleted and user remains on last page
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            //Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 3);
        }

        public void DeleteMaterial(IWebDriver driver)
        {
            Console.WriteLine("Delete the new & edited Material record");
            Thread.Sleep(2000);

            // find and click on the Go to the last page button
            //IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // verify code in last row is the correct record to delete
            IWebElement lastRowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastRowCode.Text == "my edited mtl code", "Delete ABORTED because material code in last row does not match expected material code");

            // find and click Delete button in last row by replacing digit in tr[] with last()
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            //Thread.Sleep(3000);
            //Wait.WaitForElementToBeClickable(driver, "XPath", "", 1);
            Wait.WaitForAlertBoxToBePresent(driver, 3);

            // click OK button in pop-up confirmation window - item is deleted and user remains on last page
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            //Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 3);

            // fails to find the element because deleted record was last record on the last page and the program leaves the user on
            // the last page with no rows of records to find so clicking Go to the first page button, then Go to the last page button
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[1]/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(1500);
            //if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited mtl code")
            if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited mtl code")
                {
                Console.WriteLine("Edited Material record wasn't deleted successfully");
            }
            else
            {
                Console.WriteLine("Edited Material record was deleted successfully");
            }
        }
    }
}
