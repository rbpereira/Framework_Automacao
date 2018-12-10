using Web.Comum;
using Web.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class VerificarReembolsoSteps
    {
        [Given(@"Navegar até a pagina de Verificar reembolso")]
        public void DadoNavegarAteAPaginaDeVerificarReembolso()
        {
            Funcionalidades.Clicar(MenuPage.MnuPrincipal());
            Funcionalidades.EsperarObjetoCarregar(MenuPage.VerificarReembolsosMenu());
            Funcionalidades.Esperar();
            Funcionalidades.Clicar(MenuPage.VerificarReembolsosMenu());
        }
    }
}
