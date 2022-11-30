//using _2022_November.Pages;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using NUnit.Framework;
//using _2022_November.Utilities;

namespace _2022_November.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        [Test, Order(1), Description("Check if user can create a time record with valid data")]
        public void CreateTime_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // create a new Time record in the Time and Material module
            tmPageObj.CreateTime(driver);
        }

        [Test, Order(2), Description("Check if user can edit an existing time record successfully")]
        public void EditTime_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // edit my new Time record and verify the edited value
            tmPageObj.EditTime(driver);
        }

        [Test, Order(3), Description("Check if user can delete an existing & edited time record successfully")]
        public void DeleteTime_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // delete my edited Time record and verify it was deleted by not finding it in the last row
            tmPageObj.DeleteTime(driver);
        }

        [Test, Order(4), Description("Check if user can create a material record with valid data")]
        public void CreateMaterial_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // create a new Material record in the Time and Material module
            tmPageObj.CreateMaterial(driver);
        }

        [Test, Order(5), Description("Check if user can edit a material record successfully")]
        public void EditMaterial_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // edit my new Material record and verify the edited value
            tmPageObj.EditMaterial(driver);
        }

        [Test, Order(6), Description("Check if user can delete an existing & edited material record successfully")]
        public void DeleteMaterial_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();

            // delete my edited Material record and verify it was deleted by not finding it in the last row
            tmPageObj.DeleteMaterial(driver);
        }
    }
}
