using Web.PageObject;
using System.Configuration;
using TechTalk.SpecFlow;
using static Web.Comum.TipoNavegador;

namespace Web.Comum
{
    [Binding]
    public sealed class Hooks
    {
        //Encerra todos processos em andamento.
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Funcionalidades.FecharBrowser();

            //Encerra o processo, caso ainda tenha algum em andamento.
            Funcionalidades.EncerrarProcesso();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Funcionalidades.FecharBrowser();

            //Encerra o processo, caso ainda tenha algum em andamento.
            Funcionalidades.EncerrarProcesso();
        }

        [BeforeScenario]
        public void Initialize()
        {
            Funcionalidades.Inicializar(ConfigurationManager.AppSettings["UrlHomolog"]);
            Funcionalidades.Esperar();
            if (Funcionalidades.CapturarTexto(Paginas.Pagina()).Contains("Meus reembolsos"))
            {
                Funcionalidades.Clicar(MenuPage.MnuIconeFotografia());
                Funcionalidades.EsperarObjetoCarregar(MenuPage.MnuSairIconeFotografia());
                Funcionalidades.Clicar(MenuPage.MnuSairIconeFotografia());
                Funcionalidades.EsperarObjetoCarregar(LoginPage.MsgEntrarNoSistema());
            }
        }

        

        ////fecha o browser após a execução de cada caso de teste.
        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    //Funcionalidades.FecharBrowser();
        //}

        //Tira print após cada passo
        [AfterStep()]
        public void MakeScreenshotAfterStep()
        {
            Funcionalidades.PrintScreen();
        }
    }
}
