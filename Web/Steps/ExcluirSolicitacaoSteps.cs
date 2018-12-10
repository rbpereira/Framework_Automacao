using Web.Comum;
using Web.PageObject;
using TechTalk.SpecFlow;

namespace Web.Steps
{
    [Binding]
    public class ExcluirSolicitacaoSteps
    {
        [When(@"Clicar no botão Excluir Reembolso")]
        public void QuandoClicarNoBotaoExcluirReembolso()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnExcluirReembolso());
            Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.BtnExcluir());
        }
        
        [Then(@"Clicar no botão Excluir")]
        public void EntaoClicarNoBotaoExcluir()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnExcluir());
            Funcionalidades.EsperarObjetoCarregar(SolicitarReembolsoPage.BtnOK());
        }

        [Then(@"Clicar em OK")]
        public void EntaoClicarEmOK()
        {
            Funcionalidades.Clicar(SolicitarReembolsoPage.BtnOK());
            Funcionalidades.EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
        }

        [Then(@"Verificar se o reembolso foi deletado da tabela de meus reembolsos")]
        public void EntaoVerificarSeOReembolsoFoiDeletadoDaTabelaDeMeusReembolsos()
        {
            FuncoesAplicacao.PesquisarReembolsoExcluido();
        }

    }
}
