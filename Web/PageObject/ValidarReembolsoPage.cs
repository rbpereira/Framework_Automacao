using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.PageObject
{
    public static class ValidarReembolsoPage
    {
        public static By BtnValidar()
        {
            By btn = By.XPath("//span[text() = 'VALIDAR' or text() = 'Validar']");
            return btn;
        }

        public static By BtnDevolver()
        {
            By btn = By.XPath("//span[text() = 'DEVOLVER' or text() = 'Devolver']");
            return btn;
        }

        public static By BtnValidarModal()
        {
            By btn = By.XPath("//*/p-footer/div/p-button[2]/button");
            return btn;
        }

        public static By btnDevolverModal()
        {
            By btn = By.XPath("//*/p-footer/div/p-button[2]/button");
            return btn;
        }

        public static By IcoValidar()
        {
            By btn = By.ClassName("icoValidar");
            return btn;
        }

        public static By BtnVoltar()
        {
            By btn = By.XPath("//span[text()='VOLTAR' or text()='voltar']");
            return btn;
        }

        public static By TxtPesquisar()
        {
            By txt = By.CssSelector("input[type='text']");
            return txt;
        }
    }
}
