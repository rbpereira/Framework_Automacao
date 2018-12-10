using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Web.PageObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static Web.Comum.TipoAmbiente;

namespace Web.Comum
{
    [Binding]
    public class Funcionalidades
    {
        /*****TIPOS DE LOCATORS ******
        *   id                       *
        *   Name                     *
        *   Linktext                 *
        *   Partial Linktext         *
        *   Tag Name                 *
        *   Class Name               *
        *   Css                      *
        *   Xpath                    *
        ****************************/
        public static IWebDriver Driver { get; set; }
        public static string host = ConfigurationManager.AppSettings["seleniumHub"];
        public static string BrowserConfig = ConfigurationManager.AppSettings["browser"];
        //public static string SeleniumBaseUrl = ConfigurationManager.AppSettings["seleniumBaseUrl"];
        public static ICapabilities capabilities;
        public static TimeSpan commandTimeout;
        public static DateTime strDataHora = DateTime.Now;
        public static string strDataSolicitacao;
        public static string strStatus;
        public static string strDescricao;
        public static string NumeroReembolso;
        public static string strComprovante = ConfigurationManager.AppSettings["Comprovante"];
        public static List<string> ListNumeroReembolso = new List<string>();


        //Inicialização do driver
        public static void Inicializar(string url)
        {
            if (Driver == null)
            {
                switch ((Ambiente.Local).ToString())
                {
                    case "Remoto":
                        switch (BrowserConfig.ToUpper())
                        {
                            case "CHROME":
                                capabilities = new ChromeOptions().ToCapabilities();
                                commandTimeout = TimeSpan.FromMinutes(2);
                                break;
                            case "FIREFOX":
                                capabilities = new FirefoxOptions().ToCapabilities();
                                commandTimeout = TimeSpan.FromMinutes(2);
                                break;
                            case "IE":
                                InternetExplorerOptions options;
                                options = new InternetExplorerOptions();
                                options.AddAdditionalCapability("EnsureCleanSession", true);
                                commandTimeout = TimeSpan.FromMinutes(2);
                                capabilities = options.ToCapabilities();
                                break;
                            case "EDGE":
                                EdgeOptions edgeoptions = new EdgeOptions();
                                edgeoptions.AddAdditionalCapability("EnsureCleanSession", true);
                                //edgeoptions.AddAdditionalCapability("browserName","MicrosoftEdge");
                                capabilities = edgeoptions.ToCapabilities();
                                commandTimeout = TimeSpan.FromMinutes(2);
                                break;
                            default:
                                throw new NotSupportedException($"{Driver} Não é suportado.");
                        }
                        Driver = new RemoteWebDriver(new Uri(Funcionalidades.host), capabilities, commandTimeout);
                        break;
                    case "Local":
                        //switch (browser.ToUpper())
                        switch (BrowserConfig.ToUpper())
                        {
                            case "CHROME":
                                Driver = new ChromeDriver();
                                break;
                            case "FIREFOX":
                                Driver = new FirefoxDriver();
                                break;
                            case "IE":
                                Driver = new InternetExplorerDriver();
                                break;
                            case "EDGE":
                                Driver = new EdgeDriver();
                                break;
                            default:
                                Driver = new ChromeDriver();
                                break;
                        }
                        break;
                }

                Driver.Manage().Window.Maximize();
                Driver.Url = url;
            }
            else
            {
                Driver.Url = url;
            }
        }

        //Fechar o Browser
        public static void FecharBrowser()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
                Driver = null;
            }
        }

        //Clicar em um objeto
        public static void Clicar(By Locator)
        {
            if (ObjetoEstaHabilitado(Locator) == true)
            {
                IWebElement element = Driver.FindElement(Locator);
                Actions action = new Actions(Driver);
                action.MoveToElement(element).Click().Perform();
                //Driver.FindElement(Locator).Click();
            }
            else
            {
                Assert.Fail("O objeto está desabilitado.");
            }
        }

        //Enviar texto para um objeto
        public static void EnviarTexto(string Text, By Locator)
        {
            if (!Locator.ToString().Contains("body"))
            {
                Driver.FindElement(Locator).Clear();
            }
            Driver.FindElement(Locator).SendKeys(Text);
        }

        //Capturar o texto de um objeto
        public static string CapturarTexto(By Locator)
        {
            string ObjectText = Driver.FindElement(Locator).Text.ToString();
            return ObjectText;
        }

        //Capturar o texto de um objeto
        public static string SelecionarOpcaoPorTexto(By Locator)
        {
            string ObjectText = Driver.FindElement(Locator).Text.ToString();
            return ObjectText;
        }

        //Comparar textos
        public static void CompararTexto(string TextoExperado, string TextoAtual)
        {
            Assert.AreEqual(TextoExperado, TextoAtual);
        }

        //Comparar textos
        public static void ObjetoContemTexto(string TextoExperado, string TextoAtual)
        {
            Assert.IsTrue(TextoAtual.Contains(TextoExperado));
        }

        //Selecionar uma opção dentro de um option
        public static void SelecionarOpcao(string OptionText, By Locator)
        {
            // select the drop down list
            var Object = Driver.FindElement(Locator);
            //create select element object 
            var selectElement = new SelectElement(Object);
            // select by text
            selectElement.SelectByText(OptionText);
        }

        //Tirar print da tela
        public static void PrintScreen()
        {
            //Take the screenshot
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            //Save the screenshot
            CriarNovaPasta(ConfigurationManager.AppSettings["EnderecoPrint"].ToString());

            var tempFileName = Path.Combine(ConfigurationManager.AppSettings["EnderecoPrint"].ToString(), Path.GetFileNameWithoutExtension(Path.GetTempFileName())) + ".jpg";
            screenshot.SaveAsFile(tempFileName, ScreenshotImageFormat.Jpeg);
            Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");
        }

        //Apagar informações em campos
        public static void LimparCampo(By Locator)
        {
            Driver.FindElement(Locator).Clear();
        }

        //Verifica se o objeto está visivel
        public static bool ObjetoEstaVisivel(By Locator)
        {
            bool status = Driver.FindElement(Locator).Displayed;

            return status;
        }

        //verifica se o objeto está habilitado
        public static bool ObjetoEstaHabilitado(By Locator)
        {
            bool status = Driver.FindElement(Locator).Enabled;
            return status;
        }

        //Espera o objeto carregar
        public static void EsperarObjetoCarregar(By Locator)
        {
            int secondsToWait = 10;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, secondsToWait));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(Locator));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Locator));
            wait.Until(d => d.FindElement(Locator).Enabled && d.FindElement(Locator).Displayed);
        }

        public static void EsperarTextoDesaparecer(string texto, By locator)
        {
            int secondsToWait = 30;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, secondsToWait));

            var teste = Driver.FindElement(By.XPath("//*/table/tbody/tr/td")).Text;

            wait.Until((SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementWithText((By.XPath("//*/table/tbody/tr/td")), texto)));
        }

        public static void EsperarTabelaCarregar()
        {
            int secondsToWait = 60;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, secondsToWait));
            By locator = By.XPath("//*/table/tbody/tr/td");

            wait.Until(e => e.FindElements(locator).Count > 1);
        }

        //Verifica se o objeto desapareceu da tela
        public static void VerificarQdoObjetoDesaparecer(By Locator)
        {
            int secondsToWait = 60;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, secondsToWait));


            wait.Until(d => d.FindElement(Locator).Enabled && d.FindElement(Locator).Displayed);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(Locator));

        }

        //Esperar
        public static void Esperar()
        {
            Thread.Sleep(300);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(900);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
        }

        //Encerrar processo.
        public static void EncerrarProcesso()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.ProcessName == "chromedriver" || process.ProcessName == "firefoxdriver" || process.ProcessName == "internetexplorerdriver" || process.ProcessName == "edgedriver" || process.ProcessName == "geckodriver" || process.ProcessName == "MicrosoftWebDriver")
                {
                    process.Kill();
                }
            }
        }
       

        public static void CriarNovaPasta(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

    }
}
