using NUnit.Framework;
using Web.Comum;
using Web.PageObject;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class EsqueciMinhaSenhaSteps
    {
        [When(@"Clicar no link Esqueci minha senha")]
        public void QuandoClicarNoLinkEsqueciMinhaSenha()
        {
            Funcionalidades.Clicar(LoginPage.LnkEsqueciMinhaSenha());
            Funcionalidades.Esperar();
        }
        
        [When(@"No campo Username/email inserir (.*)")]
        public void QuandoInserirUsernameEmail(string SeuLogin)
        {
            Funcionalidades.EnviarTexto(SeuLogin, EsqueciMinhaSenhaPage.TxtSeuLogin());
        }

        [When(@"Clicar no botão submit")]
        public void QuandoClicarNoBotaoSubmit()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnSubmitLogin());
        }


        [When(@"Clicar no botão Enviar")]
        public void QuandoClicarNoBotaoEnviar()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnEnviar());
        }

    }
}
