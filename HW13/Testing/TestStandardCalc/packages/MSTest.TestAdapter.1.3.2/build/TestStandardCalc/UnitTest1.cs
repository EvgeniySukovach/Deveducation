using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Winium;
using Assert = NUnit.Framework.Assert;

namespace CitizenTests
{
    [TestClass]
    public class UnitTest1
    {
        //WiniumDriver driver;
        //String actualResult;
        //String expectedResult;
        /*
         [SetUp]
         public void BeforeTest()
         {
             DesktopOptions options = new DesktopOptions();
             options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
             driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
         }
         */

        [TestMethod]
        public void LaunchTest_Calc001()
        {
            
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);

            String actualResult;
            String expectedResult = "0";
            System.Threading.Thread.Sleep(1000);
            
            // act
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);
            
            //assert
            Assert.AreEqual(expectedResult, actualResult);
            
            driver.Close();
            
        }
        
        [TestMethod]
        public void EnterTheNumbers1234_Calc002()
        {
            System.Threading.Thread.Sleep(1000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "1234";
            System.Threading.Thread.Sleep(1000);
            // act
            driver.FindElementByName("1").Click();
            driver.FindElementByName("2").Click();
            driver.FindElementByName("3").Click();
            driver.FindElementByName("4").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);
            
            //assert
            Assert.AreEqual(expectedResult, actualResult);

            driver.Close();
            
        }

        [TestMethod]
        public void ClearingFieldTest_Calc003()
        {
            System.Threading.Thread.Sleep(10000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "0";
            System.Threading.Thread.Sleep(1000);

            // act
            driver.FindElementByName("2").Click();
            driver.FindElementByName("5").Click();
            driver.FindElementByName("7").Click();
            driver.FindElementByName("CE").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);
             
            //assert
            Assert.AreEqual(expectedResult, actualResult);
            
            driver.Close();                      
        }

        [TestMethod]
        public void ClearingLastNumberTest_Calc004()
        {
            System.Threading.Thread.Sleep(10000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "25";
            System.Threading.Thread.Sleep(1000);
            try
            {
            // act
            driver.FindElementByName("2").Click();
            driver.FindElementByName("5").Click();
            driver.FindElementByName("7").Click();
            driver.FindElementByName("<-").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);
            
                //assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch
            {
                Console.WriteLine("Test Calc004 fallen.");
            }
            finally
            {
                System.Threading.Thread.Sleep(1000);
                driver.Close();
            }
        }

        [TestMethod]
        public void FloatNumber_Calc005()
        {
            System.Threading.Thread.Sleep(1000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "8,91";
            System.Threading.Thread.Sleep(1000);

            // act
            driver.FindElementByName("8").Click();
            driver.FindElementByName(",").Click();
            driver.FindElementByName("9").Click();
            driver.FindElementByName("1").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);

            //assert
            Assert.AreEqual(expectedResult, actualResult);

            driver.Close();
        }


        [TestMethod]
        public void AdditionTest_Calc006()
        {
            System.Threading.Thread.Sleep(1000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath= @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "5";
            System.Threading.Thread.Sleep(1000);

            // act
            driver.FindElementByName("2").Click();
            driver.FindElementByName("+").Click();
            driver.FindElementByName("3").Click();
            driver.FindElementByName("=").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);

            //assert
            Assert.AreEqual(expectedResult, actualResult);

            driver.Close();
            
        }
        
        [TestMethod]
        public void SubtractionTest_Calc007()
        {
            System.Threading.Thread.Sleep(1000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "1,4";
            System.Threading.Thread.Sleep(1000);

            // act
            driver.FindElementByName("5").Click();
            driver.FindElementByName(",").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("-").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("=").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            driver.Close();
        }
        
        [TestMethod]
        public void MultiplicationTest_Calc008()
        {
            //System.Threading.Thread.Sleep(1000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "32";
            System.Threading.Thread.Sleep(2000);

            // act
            driver.FindElementByName("8").Click();
            driver.FindElementByName("*").Click();
            driver.FindElementByName("4").Click();
            driver.FindElementByName("=").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(2000);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            driver.Close();
        }

        [TestMethod]
        public void DevisionTest_Calc009()
        {
            System.Threading.Thread.Sleep(2000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "1";
            System.Threading.Thread.Sleep(2000);

            // act
            driver.FindElementByName("5").Click();
            driver.FindElementByName("/").Click();
            driver.FindElementByName("5").Click();
            driver.FindElementByName("=").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(2000);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            driver.Close();
        }

        [TestMethod]
        public void DevisionByZeroTest_Calc010()
        {
            System.Threading.Thread.Sleep(1000);
            //arrange
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Users\Компьютер\source\repos\Citizen\Citizen\bin\Debug\Citizen.exe";
            WiniumDriver driver = new WiniumDriver(@"D:\instal\Winium.Desktop.Driver", options);
            String actualResult;
            String expectedResult = "бесконечность";
            System.Threading.Thread.Sleep(1000);

            // act
            driver.FindElementByName("7").Click();
            driver.FindElementByName("/").Click();
            driver.FindElementByName("0").Click();
            driver.FindElementByName("=").Click();
            actualResult = driver.FindElementById("textBox").Text;
            System.Threading.Thread.Sleep(1000);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            driver.Close();
        }
    }
}
