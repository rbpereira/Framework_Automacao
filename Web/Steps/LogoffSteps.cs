using NUnit.Framework;
using Web.Comum;
using Web.PageObject;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class LogoffSteps
    {
        [Given(@"Que o usuário (.*) esteja logado no sistema")]
        public void DadoQueOUsuarioEstejaLogadoNoSistema(string Usuario)
        {
            //Funcionalidades.Esperar();
            Funcionalidades.EsperarObjetoCarregar(LoginPage.MsgEntrarNoSistema());

            switch (Usuario.ToUpper())
            {
                case ("SOLICITANTE"):
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["LoginSolicitante"], LoginPage.TxtSeuLogin());
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["SenhaSolicitante"], LoginPage.TxtSuaSenha());
                    break;
                case ("APROVADOR"):
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["LoginAprovador"], LoginPage.TxtSeuLogin());
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["SenhaAprovador"], LoginPage.TxtSuaSenha());
                    break;
                case ("SECRETARIA"):
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["LoginSecretaria"], LoginPage.TxtSeuLogin());
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["SenhaSecretaria"], LoginPage.TxtSuaSenha());
                    break;
                case ("FINANCEIRO"):
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["LoginFinanceiro"], LoginPage.TxtSeuLogin());
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["SenhaFinanceiro"], LoginPage.TxtSuaSenha());
                    break;
                case ("COORDENADOR"):
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["LoginCoordenador"], LoginPage.TxtSeuLogin());
                    Funcionalidades.EnviarTexto(ConfigurationManager.AppSettings["SenhaCoordenador"], LoginPage.TxtSuaSenha());
                    break;
            }

            Funcionalidades.Clicar(LoginPage.BtnEntrar());
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.TblReembolsos());
            //Funcionalidades.EsperarTabelaCarregar();
            
        }
        
        [When(@"Clicar no menu com o icone da fotografica")]
        public void QuandoClicarNoMenuComOIconeDaFotografica()
        {
            Funcionalidades.Clicar(MenuPage.MnuIconeFotografia());
            Funcionalidades.EsperarObjetoCarregar(MenuPage.MnuSairIconeFotografia());
        }

        [When(@"Clicar no menu principal")]
        public void QuandoClicarNoMenuPrincipal()
        {
            Funcionalidades.Clicar(MenuPage.MnuPrincipal());
            Funcionalidades.EsperarObjetoCarregar(MenuPage.MnuSairIconeMenu());
        }

        [When(@"Clicar no menu Sair")]
        public void QuandoClicarNoMenuSair()
        {
            if (Funcionalidades.ObjetoEstaVisivel(MenuPage.MnuSairIconeFotografia()))
            {
                Funcionalidades.Clicar(MenuPage.MnuSairIconeFotografia());
                Funcionalidades.EsperarObjetoCarregar(LoginPage.MsgEntrarNoSistema());
            }
            else
            {
                Funcionalidades.Clicar(MenuPage.MnuSairIconeMenu());
                Funcionalidades.EsperarObjetoCarregar(LoginPage.MsgEntrarNoSistema());
            }
        }

        [Then(@"O usuário é desconectado do sistema retornando para tela de login (.*)")]
        public void EntaoOUsuarioEDesconectadoDoSistemaRetornandoParaTelaDeLogin(string strMensagem)
        {
            Funcionalidades.CompararTexto(strMensagem, Funcionalidades.CapturarTexto(LoginPage.MsgEntrarNoSistema()));
        }
    }
}
