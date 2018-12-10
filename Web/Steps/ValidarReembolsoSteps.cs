using NUnit.Framework;
using Web.Comum;
using Web.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class CN11_ValidarReembolsoSteps
    {
        [Given(@"Navegar até a pagina de Validar reembolso")]
        public void DadoNavegarAteAPaginaDeValidarReembolso()
        {
            Funcionalidades.Clicar(MenuPage.MnuPrincipal());
            Funcionalidades.EsperarObjetoCarregar(MenuPage.ValidarReembolsosMenu());
            Funcionalidades.Esperar();
            Funcionalidades.Clicar(MenuPage.ValidarReembolsosMenu());
        }
        
        [When(@"selecionar uma solicitação")]
        public void QuandoSelecionarUmaSolicitacao()
        {
            FuncoesAplicacao.SelecionarReembolsoTblValidar();
            Funcionalidades.EsperarObjetoCarregar(ValidarReembolsoPage.BtnValidar());
        }
        
        [When(@"Clicar no botão validar")]
        public void QuandoClicarNoBotaoValidar()
        {
            Funcionalidades.Clicar(ValidarReembolsoPage.BtnValidar());
            Funcionalidades.EsperarObjetoCarregar(ValidarReembolsoPage.BtnValidarModal());
            Funcionalidades.Esperar();
        }
        
        [When(@"Confirmar a validação")]
        public void QuandoConfirmarAValidacao()
        {
            Funcionalidades.Clicar(ValidarReembolsoPage.BtnValidarModal());
            Funcionalidades.Esperar();
        }
        
        [When(@"Confirmar Devolução")]
        public void QuandoConfirmarDevolucao()
        {
            Funcionalidades.Clicar(ValidarReembolsoPage.BtnValidarModal());
            Funcionalidades.Esperar();
        }
        
        [Then(@"Verificar se na tabela Validar não consta a solicitação")]
        public void EntaoVerificarSeNaTabelaValidarNaoConstaASolicitacao()
        {
            Funcionalidades.EsperarTabelaCarregar();
            Funcionalidades.EnviarTexto(Funcionalidades.NumeroReembolso, ValidarReembolsoPage.TxtPesquisar());
            Funcionalidades.Esperar();
            Funcionalidades.Esperar();
            int rows = FuncoesAplicacao.ContarQtdeLinhasTabela();
            if (rows > 1)
            {
                Assert.Fail("A solicitação não foi validada/devolvida");
            }
        }

        [When(@"Clicar no botão Voltar da pagina Reembolso")]
        public void QuandoClicarNoBotaoVoltarDaPaginaReembolso()
        {
            Funcionalidades.Clicar(ValidarReembolsoPage.BtnVoltar());
            Funcionalidades.Esperar();
            Funcionalidades.Esperar();
            Funcionalidades.Esperar();

        }

    }
}
