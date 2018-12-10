using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class VerificarReembolsoPage
    {
        public static By BtnValidar()
        {
            By btn = By.XPath("//span[text() = 'VALIDAR' or text() = 'Validar']");
            return btn;
        }
    }
}
