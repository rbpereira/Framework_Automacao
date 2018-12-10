using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class Paginas
    {
        public static By Pagina()
        {
            By pag = (By.XPath("/html/body"));
            return pag;
        }
    }
}
