using NUnit.Framework;
using Web.Comum;
using Web.PageObject;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class LoginSteps
    {

        [Given(@"Que o sistema esteja aberto na pagina de login")]
        public void DadoQueOSistemaEstejaAbertoNaPaginaDeLogin()
        {
            //Funcionalidades.Inicializar(ENavegador.Navegador.Chrome.ToString(), ConfigurationManager.AppSettings["UrlHomolog"]);
            //Funcionalidades.Esperar();
            Funcionalidades.EsperarObjetoCarregar(LoginPage.MsgEntrarNoSistema());
        }
        
        [When(@"Digitar login (.*) e senha (.*)")]
        public void QuandoDigitarLoginESenha(string strLogin, string strSenha)
        {
            Funcionalidades.EsperarObjetoCarregar(LoginPage.MsgEntrarNoSistema());
            Funcionalidades.EnviarTexto(strLogin, LoginPage.TxtSeuLogin());
            Funcionalidades.EnviarTexto(strSenha, LoginPage.TxtSuaSenha());
        }
        
        [When(@"Clicar no botão Entrar")]
        public void ClicarNoBotaoEntrar()
        {
            Funcionalidades.Clicar(LoginPage.BtnEntrar());
            Funcionalidades.Esperar();
        }
        
        [Then(@"É apresentanda a mensagem (.*)")]
        public void EntaoEApresentandaAMensagem(string strMensagem)
        {
            Funcionalidades.Esperar();
            Funcionalidades.ObjetoContemTexto(strMensagem, Funcionalidades.CapturarTexto(Paginas.Pagina()));
        }
    }
}
