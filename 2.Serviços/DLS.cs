using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestUber._2.Serviços
{
   public class DLS
    {
        private WebDriver driver;

        public DLS(WebDriver driver)
        {
            this.driver = driver;
        }

        public void escreve(String id_campo, string texto)
        {
            driver.FindElement(By.Id(id_campo)).Clear();
            driver.FindElement(By.Id(id_campo)).SendKeys(texto);
        }
        public void escreveAttribute(String id_campo, string att)
        {
            driver.FindElement(By.Id(id_campo)).GetAttribute(att);
        }
        public void escreveXPath(String id_campo, string texto)
        {
            driver.FindElement(By.XPath(id_campo)).SendKeys(texto);
        }
        public void escreveComClick(String id_campo)
        {
            driver.FindElement(By.Id(id_campo)).Click();
        }
        public void PreencherCombo(string id, string valor)
        {
            WebElement element = (WebElement)driver.FindElement(By.Id(id));
            var combo = new SelectElement((IWebElement)element);
            combo.SelectByText(valor);
        }
        public string ObterTexto(string texto)
        {
            return driver.FindElement(By.XPath(texto)).Text;
        }

        public void CadastarButtonId(string id_campo)
        {
            driver.FindElement(By.Id(id_campo)).Click();
        }
        public void ClickByCssSelector(string selector_campo)
        {
            driver.FindElement(By.CssSelector(selector_campo)).Click();
        }
        public void CadastarButtonXPath(string xp_campo)
        {
            driver.FindElement(By.XPath(xp_campo)).Click();
        }
        public void InserirEmail(string email, string id_campo)
        {
            driver.FindElement(By.Id(id_campo)).SendKeys(email);
        }
        public void InserirSenha(string id_campo, string texto)
        {
            driver.FindElement(By.Id(id_campo)).SendKeys(texto);
        }
        public void DeveUtilizarAEsperaImplicita()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }
        public void DeveVerificarSeOElementoEstaVisivel(string nome)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _ = driver.FindElement(By.CssSelector(nome)).Displayed;
            //div[data-identity='pagination-next']
        }
        public string ObterTextoClassName(string texto)
        {
            return driver.FindElement(By.ClassName(texto)).Text;
        }

    }
}
