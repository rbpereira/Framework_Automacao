using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class MenuPage
    {
        public static By MnuIconeFotografia()
        {
            By IconeFotografia = (By.XPath("/html/body/app-root/app-home/app-header/nav/div/div[2]/div/div[3]/div[1]/img"));
            return IconeFotografia;
        }

        public static By MnuPrincipal()
        {
            By Principal = (By.Id("sidebarCollapse"));
            return Principal;
        }

        public static By MnuMeusDados()
        {
            By eusDados = (By.XPath("/html/body/app-root/app-home/app-header/nav/div/div[2]/div/div[3]/div[2]/ul/li[1]"));
            return eusDados;
        }

        public static By MnuConfiguracao()
        {
            By Configuracao = (By.XPath("/html/body/app-root/app-home/app-header/nav/div/div[2]/div/div[3]/div[2]/ul/li[2]"));
            return Configuracao;
        }

        public static By MnuSairIconeFotografia()
        {
            By Sair = (By.XPath("/html/body/app-root/app-home/app-header/nav/div/div[2]/div/div[3]/div[2]/ul/li[3]/div"));
            return Sair;
        }
        public static By MnuSairIconeMenu()
        {
            By Sair = (By.XPath("/html/body/app-root/app-home/app-header/div/nav/div[4]/a"));
            return Sair;
        }

        public static By AprovarReembolsosMenu()
        {
            By mnu = (By.XPath("//a[text()='Aprovar reembolsos']"));
            return mnu;
        }

        public static By ValidarReembolsosMenu()
        {
            By mnu = (By.XPath("//a[text()='Validar']"));
            return mnu;
        }

        public static By VerificarReembolsosMenu()
        {
            By mnu = (By.XPath("//a[text()='Verificar']"));
            return mnu;
        }
    }
}
