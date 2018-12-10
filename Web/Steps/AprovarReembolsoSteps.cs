using Web.Comum;
using Web.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class AprovarReembolsoSteps
    {
        public string NumeroReembolso;

        [When(@"Selecionar a quantidade de reembolsos (.*)")]
        public void QuandoSelecionarUmReembolso(int quantidade)
        {
            FuncoesAplicacao.SelecionarReembolso(quantidade);
        }
        
        [When(@"Na tabela clicar no botão (.*)")]
        public void QuandoNaTabelaClicarNoBotao(string acao)
        {
            FuncoesAplicacao.VisualizarAprovarReprovarDevolverReembolso(acao);
        }
        
        [When(@"Validar a mensagem (.*)")]
        public void QuandoValidarAMensagem(string mensagem)
        {
            Funcionalidades.Esperar();
            Funcionalidades.Esperar();
            Funcionalidades.ObjetoContemTexto(mensagem,Funcionalidades.CapturarTexto(Paginas.Pagina()));
        }
        
        [When(@"Clicar no botão Aprovar")]
        public void QuandoClicarNoBotaoAprovar()
        {
            Funcionalidades.Clicar(AprovarReembolsoPage.BtnAprovar());
            Funcionalidades.EsperarObjetoCarregar(AprovarReembolsoPage.ModalMensagemValidacao());
            Funcionalidades.Esperar();
        }

        [When(@"Clicar no botão Reprovar")]
        public void QuandoClicarNoBotaoReprovar()
        {
            Funcionalidades.Clicar(AprovarReembolsoPage.BtnReprovar());
            Funcionalidades.EsperarObjetoCarregar(AprovarReembolsoPage.ModalMensagemValidacao());
            Funcionalidades.Esperar();
        }

        [When(@"Clicar no botão Devolver")]
        public void QuandoClicarNoBotaoDevolver()
        {
            Funcionalidades.Clicar(AprovarReembolsoPage.BtnDevolver());
            Funcionalidades.EsperarObjetoCarregar(AprovarReembolsoPage.ModalMensagemValidacao());
            Funcionalidades.Esperar();

        }

        [Then(@"Verificar se o reembolso consta na lista para aprovar")]
        public void EntaoVerificarSeOReembolsoConstaNaListaParaAprovar()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Inserir Justificativa (.*)")]
        public void QuandoInserirJustificativa(string justificativa)
        {
            Funcionalidades.EnviarTexto(justificativa, AprovarReembolsoPage.TxtJustificativa());
        }


        [Then(@"Verificar se a solicitação consta na lista para aprovar")]
        public void EntaoVerificarSeASolicitacaoConstaNaListaParaAprovar()
        {
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            Funcionalidades.EsperarTabelaCarregar();
            FuncoesAplicacao.PesquisarReembolsoTlbAprovar();
        }

        [Given(@"Navegar até a pagina de aprovar reembolso")]
        public void DadoNavegarAteAPaginaDeAprovarReembolso()
        {
            Funcionalidades.Clicar(MenuPage.MnuPrincipal());
            Funcionalidades.EsperarObjetoCarregar(MenuPage.AprovarReembolsosMenu());
            Funcionalidades.Clicar(MenuPage.AprovarReembolsosMenu());
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            Funcionalidades.EsperarTabelaCarregar();
        }


        [When(@"clicar no botão Aprovar Selecionados")]
        public void QuandoClicarNoBotaoAprovarSelecionados()
        {
            Funcionalidades.Clicar(AprovarReembolsoPage.BtnAprovarSelecionados());
        }

    }
}
