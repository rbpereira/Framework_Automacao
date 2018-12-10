using NUnit.Framework;
using OpenQA.Selenium;
using Web.Comum;
using Web.PageObject;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class SolicitarReembolsoSteps
    {
        public string DescricaoCurso;
        [When(@"Iniciar uma nova solicitação")]
        public void QuandoIniciarUmaNovaSolicitacao()
        {
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.TblReembolsos());
            Funcionalidades.Clicar(MeusReembolsosPage.BtnSolicitarReembolso());
            Funcionalidades.Esperar();
        }

        [When(@"Informar o motivo (.*), qual (.*) e descrição (.*)")]
        public void QuandoInformarOMotivoQualEDescricao(string motivo, string qual, string descricao)
        {
            FuncoesAplicacao.SelecionarMotivo(motivo);

            switch (motivo)
            {
                case "Curso":
                    DescricaoCurso = Listas.Cursos();
                    Funcionalidades.EnviarTexto(DescricaoCurso, SolicitarReembolsoPage.TxtDescricao());
                    break;
                case "Outro":
                    Funcionalidades.EnviarTexto(qual, SolicitarReembolsoPage.TxtInformeMotivo());
                    Funcionalidades.EnviarTexto(descricao, SolicitarReembolsoPage.TxtDescricao());
                    break;
                default:
                    Funcionalidades.EnviarTexto(descricao, SolicitarReembolsoPage.TxtDescricao());
                    break;
            }
        }

        [When(@"Informar se está associado a um recurso (.*), recurso (.*) e Cod/Descrição (.*)")]
        public void QuandoInformarSeEstaAssociadoAUmRecursoRecursoECodDescricao(string temRecurso, string recurso, string descricao)
        {
            if (temRecurso == "Sim")
            {
                Funcionalidades.Clicar(SolicitarReembolsoPage.RdbSelectRecursoSim());
                Funcionalidades.Esperar();
                FuncoesAplicacao.SelecionarRecurso(recurso);
                Funcionalidades.EnviarTexto(descricao, SolicitarReembolsoPage.TxtCodDescricao());
            }
            else
            {
                Funcionalidades.Clicar(SolicitarReembolsoPage.RdbSelectRecursoNao());
                Funcionalidades.Esperar();
            }
        }

        [When(@"Clicar no botão adicionar despesas")]
        public void QuandoClicarNoBotaoAdicionarDespesas()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnAdicionarDespesa());
            Funcionalidades.Esperar();
        }

        [When(@"Inserir despesas (.*), origem (.*) e destino (.*) e comprovante (.*)")]
        public void QuandoInserirDespesas(string despesas, string origem, string destino, string comprovante)
        {
            switch (despesas)
            {
                case "Estacionamento":
                    FuncoesAplicacao.InserirDespesaEstacionamento(origem, destino, comprovante);
                    break;
                case "MetroTrem":
                    FuncoesAplicacao.InserirDespesaMetroTrem(Listas.Estacoes(), Listas.Estacoes());
                    break;
                case "Onibus":
                    FuncoesAplicacao.InserirDespesaOnibus(Listas.Locais(), Listas.Locais());
                    break;
                case "Pedagio":
                    FuncoesAplicacao.InserirDespesaPedagio(comprovante);
                    break;
                case "Taxi":
                    FuncoesAplicacao.InserirDespesaTaxi(origem, destino, comprovante);
                    break;
                case "VeiculoProprio":
                    FuncoesAplicacao.InserirDespesaVeiculoProprio(origem, destino);
                    break;
            }
        }

        [When(@"Salvar despesas")]
        public void QuandoSalvarDespesas()
        {
            Funcionalidades.Esperar();
            Funcionalidades.EnviarTexto(Keys.PageDown, Paginas.Pagina());
            Funcionalidades.Clicar(ModalAdicionarDespesaMetroTremPage.BtnSalvar());
            Funcionalidades.Esperar();
            Funcionalidades.EnviarTexto(Keys.PageDown, Paginas.Pagina());
        }

        [When(@"Enviar para (.*)")]
        public void QuandoEnviarPara(string enviarPara)
        {
            switch (enviarPara)
            {
                case "Rascunho":
                    Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.BtnSalvarComoRascunho());
                    Funcionalidades.Clicar(SolicitarReembolsoPage.BtnSalvarComoRascunho());
                    Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
                    Funcionalidades.EsperarTabelaCarregar();
                    break;
                case "Aprovacao":
                    Funcionalidades.Clicar(SolicitarReembolsoPage.BtnEnviarParaAprovacao());
                    Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.BtnEnviar());
                    Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
                    Funcionalidades.EsperarTabelaCarregar();
                    break;
            }
        }

        [Then(@"Validar informações do envio ou rascunho (.*)")]
        public void ValidarInformacoesEnvioRascunho(string descricao)
        {
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.TblReembolsos());
            Funcionalidades.EsperarTabelaCarregar();
            //Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.TblReembolsos());
            FuncoesAplicacao.PesquisarValorTabela(MeusReembolsosPage.TblReembolsos(), DescricaoCurso ?? descricao);
        }

        [Then(@"Confirmar o envio")]
        public void EntaoConfirmarOEnvio()
        {
            if (Funcionalidades.CapturarTexto(Paginas.Pagina()).Contains("Enviar reembolso para aprovação?") == true)
            {
                Funcionalidades.Clicar(SolicitarReembolsoPage.BtnEnviar());
                Funcionalidades.Esperar();
                Funcionalidades.EsperarTabelaCarregar();
                Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
                Funcionalidades.EsperarTabelaCarregar();
                
            }
            else
            {
                Assert.True(true);
            }
        }



        [Then(@"Validar o valor total de despesas")]
        public void ValidarOValorTotalDeDespesas()
        {
            Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.TblDespesas());
            FuncoesAplicacao.ValidarValorTotalDespesas(SolicitarReembolsoPage.TblDespesas());
        }

        [Then(@"Excluir uma Despesa")]
        public void EntaoExcluirUmaDespesa()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnExcluirDespesa());
        }

        [When(@"Clicar no botão Voltar")]
        public void QuandoClicarNoBotaoVoltar()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnVoltar());
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.TblReembolsos());
        }

        [When(@"Informar o (.*) do estabelecimento")]
        public void QuandoInformarO_DoEstabelecimento(string CNPJ)
        {
            Funcionalidades.EnviarTexto(CNPJ, ModalAdicionarDespesaEstacionamentoPage.TxtCnpjEstabelecimento());
        }


        [When(@"Clicar no botão Cancelar Reembolso")]
        public void QuandoClicarNoBotaoCancelarReembolso()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnCancelarReembolso());
        }


        [Then(@"Validar mensagem (.*) de confirmação")]
        public void EntaoValidarMensagemDeConfirmacao(string msg)
        {
            Funcionalidades.CompararTexto(msg, Funcionalidades.CapturarTexto(SolicitarReembolsoPage.MsgReembolsoExcluidoComSucesso()));
        }

        [Then(@"Confirmar o cancelamento do reembolso")]
        public void EntaoConfirmarOCancelamentoDoReembolso()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnSim());
            Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.BtnOK());
        }

        [Then(@"Clicar no botao OK")]
        public void EntaoClicarNoBotaoOK()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnOK());
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
        }
    }
}