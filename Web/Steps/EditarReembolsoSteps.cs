using NUnit.Framework;
using Web.Comum;
using Web.PageObject;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class EditarReembolsoSteps
    {
        [When(@"Visualizar solicitação com status (.*)")]
        public void QuandoVisualizarSolicitacaoComStatus(string status)
        {
            Funcionalidades.EsperarTabelaCarregar();
            FuncoesAplicacao.VisualizarReembolsos(status, MeusReembolsosPage.TblReembolsos());
            Funcionalidades.Esperar();
            if (status.Contains("Devolvido"))
            {
                Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.ModalJustificativa());
            }
        }
        
        [When(@"Validar a justificativa (.*)")]
        public void QuandoValidarAJustificativa(string justificativa)
        {
            Funcionalidades.ObjetoContemTexto(justificativa, Funcionalidades.CapturarTexto(Paginas.Pagina()));
        }
        
        [When(@"Fechar o modal")]
        public void QuandoFecharOModal()
        {
            Funcionalidades.Clicar(AprovarReembolsoPage.BtnFecharModal());
            Funcionalidades.Esperar();
        }

        [When(@"Fechar modal de justificativa")]
        public void QuandoFecharModalDeJustificativa()
        {
            Funcionalidades.Clicar(AprovarReembolsoPage.BtnFecharModalJustificativa());
            Funcionalidades.Esperar();
        }


        [When(@"Salvar despesa editada")]
        public void QuandoSalvarDespesaEditada()
        {
            Funcionalidades.Clicar(ModalAdicionarDespesaOnibusPage.BtnSalvarEdicao());
            Funcionalidades.Esperar();
        }


        [When(@"Clicar no botão Enviar novamente")]
        public void QuandoClicarNoBotaoEnviarNovamente()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnEnviarNovamente());
            Funcionalidades.Esperar();
            Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.BtnEnviar());
        }
        
        [When(@"Inserir uma observação (.*)")]
        public void QuandoInserirUmaObservacao(string observacao)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no botão Enviar para aprovação")]
        public void QuandoClicarNoBotaoEnviarParaAprovacao()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnEnviarParaAprovacao());
            Funcionalidades.Esperar();
        }
        

        [When(@"Excluir uma Despesa")]
        public void QuandoExcluirUmaDespesa()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnExcluirDespesa());
            Funcionalidades.Esperar();
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnExcluir());
            Funcionalidades.Esperar();
        }


        [Then(@"Validar a mensagem (.*)")]
        public void EntaoValidarAMensagem(string mensagem)
        {
            Funcionalidades.ObjetoContemTexto(mensagem, Funcionalidades.CapturarTexto(Paginas.Pagina()));
        }
        
        [Then(@"Clicar no botão OK")]
        public void EntaoClicarNoBotaoOK()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnOK());
            Funcionalidades.Esperar();
        }
        
        [Then(@"Validar se o status foi alterado para Aguardando aprovação do Gestor")]
        public void EntaoValidarSeOStatusFoiAlteradoParaAguardandoAprovacaoDoGestor()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Validar o valor total de despesas")]
        public void ValidarOValorTotalDeDespesas()
        {
            Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.TblDespesas());
            Funcionalidades.Esperar();
            FuncoesAplicacao.ValidarValorTotalDespesas(SolicitarReembolsoPage.TblDespesas());
        }

        [Then(@"Validar se o status foi alterado para (.*)")]
        public void ValidarSeOStatusFoiAlterado(string status)
        {
            Funcionalidades.Esperar();
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            Funcionalidades.Esperar();
            FuncoesAplicacao.ValidarStatus(status);
        }
    }
}
