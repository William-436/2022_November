
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


// open Chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

Console.WriteLine("**Starting Turnup portal script");
// Log in to the Turnup portal
Console.WriteLine("Log in to the Turnup portal");

// launch Turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify Username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify Password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// click Log in button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");

}
// create a new Time record in the Time and Material module
Console.WriteLine("Create a new Time record in the Time and Materials module");

// navigate to Time and Materials page
//IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
//administrationDropdown.Click();
driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
Thread.Sleep(500);

// select Time & Materials from the Administration drop-down list
//IWebElement tandmElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
//tandmElement.Click();
driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

// click on Create New button
Thread.Sleep(1500);
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
Thread.Sleep(500);

// expand TypeCode drop-down box
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typecodeDropdown.Click();
Thread.Sleep(500);

// select Time in TypeCode drop-down list
IWebElement timeElement = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeElement.Click();

// enter code in the Code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("my time code");

// enter description in the Description textbox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("my time description");

// enter price in the Price per unit textbox
IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
overlappingTag.Click();

IWebElement priceperunitTextbox = driver.FindElement(By.Id("Price"));
priceperunitTextbox.SendKeys("13");

// click Save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);

// check if new time record has been created successfully
// find and click on the Go to the last page button
IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastpageButton.Click();

// replace digit in tr[] with last() to get last row in table
IWebElement lastnewCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (lastnewCode.Text == "my time code")
{
    Console.WriteLine("Time record created successfully");
}
else
{
    Console.WriteLine("Time record wasn't created successfully");
}

// edit my new Time record and verify the edited value
Console.WriteLine("Edit the new Time record");

// replace digit in tr[] with last() to get last row in table
IWebElement lasteditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
lasteditButton.Click();

// edit the code in the Code textbox
IWebElement codeTextbox2 = driver.FindElement(By.Id("Code"));
codeTextbox2.Clear();
codeTextbox2.SendKeys("my edited time code");

// click Save button
IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
saveButton2.Click();
Thread.Sleep(2000);

// check if edited time record has been updated successfully
// find and click on the Go to the last page button
IWebElement lastpageButton2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastpageButton2.Click();

// replace digit in tr[] with last() to get last row in table
IWebElement lastrowCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (lastrowCode.Text == "my edited time code")
{
    Console.WriteLine("Time record was edited successfully");
}
else
{
    Console.WriteLine("Time record wasn't edited successfully");
}


// delete my edited Time record and verify it was deleted by not finding it in the last row
// because I don't know how to extract the total rec cnt from the lower-right corner
Console.WriteLine("Delete the new & edited Time record");

// replace digit in tr[] with last() to get last row in table
IWebElement lastdeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
lastdeleteButton.Click();

// click OK button in pop-up confirmation window


// create a new Material record in the Time and Material module
Console.WriteLine("Create a new Material record in the Time and Materials module");

// click on Create New button
Thread.Sleep(1500);
IWebElement createNewButton2 = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton2.Click();
//createNewButton.Click();
Thread.Sleep(500);


//*****************left off here


// expand TypeCode drop-down box
//IWebElement typecode2Dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
//typecode2Dropdown.Click();
typecodeDropdown.Click();
Thread.Sleep(500);

// select Material in drop-down list
IWebElement materialElement = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
materialElement.Click();

// enter code in the Code textbox
//IWebElement code2Textbox = driver.FindElement(By.Id("Code"));
//code2Textbox.SendKeys("my material code");
codeTextbox.SendKeys("my material code");

// enter description in the Description textbox
//IWebElement description2Textbox = driver.FindElement(By.Id("Description"));
//description2Textbox.SendKeys("my material description");
descriptionTextbox.SendKeys("my material description");

// enter price in the Price per unit textbox
//IWebElement overlapping2Tag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
//overlapping2Tag.Click();
overlappingTag.Click();

//IWebElement priceperunit2Textbox = driver.FindElement(By.Id("Price"));
//priceperunit2Textbox.SendKeys("1333");
priceperunitTextbox.SendKeys("1333");

// click Save button
//IWebElement save2Button = driver.FindElement(By.Id("SaveButton"));
//save2Button.Click();
saveButton.Click();
Thread.Sleep(2000);

// check if new material record has been created successfully
//IWebElement lastpage2Button = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//lastpage2Button.Click();
lastpageButton.Click();

// replace digit in [] with last() to get last row in table
IWebElement lastnew2Code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (lastnew2Code.Text == "my material code")
{
    Console.WriteLine("Material record created successfully");
}
else
{
    Console.WriteLine("Material record wasn't created successfully");
}

// edit my Material record and verify the edited value

// delete my edited Material record and verify it was deleted

Console.WriteLine("**Exiting/Ending Turnup portal script");
