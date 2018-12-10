﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Reembolso.Features.Solicitante
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CN05 - Editar Reembolso", Description="\tFuncionalidade destinada a permitir que os colaboradores da Prodesp Edite as sol" +
        "icitações criadas.", SourceFile="Features\\Solicitante\\Editar Reembolso.feature", SourceLine=1)]
    public partial class CN05_EditarReembolsoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Editar Reembolso.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "CN05 - Editar Reembolso", "\tFuncionalidade destinada a permitir que os colaboradores da Prodesp Edite as sol" +
                    "icitações criadas.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CN05_EditarSolicitacao_QdoDevolvida(string usuario, string mensagem, string mensagemInterrogativa, string justificativa, string observacao, string statusAtual, string novoStatus, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN05 - editarSolicitacao_QdoDevolvida", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("Que o usuário {0} esteja logado no sistema", usuario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.When(string.Format("Visualizar solicitação com status {0}", statusAtual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.And(string.Format("Validar a justificativa {0}", justificativa), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And("Fechar modal de justificativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.And("Clicar no botão Enviar novamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 12
 testRunner.And(string.Format("Validar a mensagem {0}", mensagemInterrogativa), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
 testRunner.And("Clicar no botão Enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.Then(string.Format("Validar se o status foi alterado para {0}", novoStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("CN05 - editarSolicitacao_QdoDevolvida, solicitante", new string[] {
                "Browser_Chrome"}, SourceLine=18)]
        public virtual void CN05_EditarSolicitacao_QdoDevolvida_Solicitante()
        {
#line 6
this.CN05_EditarSolicitacao_QdoDevolvida("solicitante", "Reembolso enviado com sucesso!", "Enviar reembolso para aprovação?", "O seu reembolso foi devolvido pelo Gestor", "Corrigido", "Devolvido (gestor)", "Aguardando validação coordenador", ((string[])(null)));
#line hidden
        }
        
        public virtual void CN05_EditarSolicitacao_QdoRascunhoInserirDespesa(string usuario, string mensagem, string despesas, string statusAtual, string novoStatus, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN05 - editarSolicitacao_QdoRascunhoInserirDespesa", @__tags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given(string.Format("Que o usuário {0} esteja logado no sistema", usuario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 24
 testRunner.When(string.Format("Visualizar solicitação com status {0}", statusAtual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 25
 testRunner.And("Clicar no botão adicionar despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 26
 testRunner.And(string.Format("Inserir despesas {0}, origem <origem> e destino <destino> e comprovante <CaminhoC" +
                        "omprovante>", despesas), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
 testRunner.And("Salvar despesa editada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 28
 testRunner.And("Validar o valor total de despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.And("Clicar no botão Enviar para aprovação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 30
 testRunner.Then("É apresentanda a mensagem Enviar reembolso para aprovação?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 31
 testRunner.And("Confirmar o envio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 32
 testRunner.And(string.Format("Validar se o status foi alterado para {0}", novoStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("CN05 - editarSolicitacao_QdoRascunhoInserirDespesa, solicitante", new string[] {
                "Browser_Chrome"}, SourceLine=34)]
        public virtual void CN05_EditarSolicitacao_QdoRascunhoInserirDespesa_Solicitante()
        {
#line 22
this.CN05_EditarSolicitacao_QdoRascunhoInserirDespesa("solicitante", "Reembolso enviado com sucesso!", "Onibus", "rascunho", "Aguardando validação coordenador", ((string[])(null)));
#line hidden
        }
        
        public virtual void CN05_EditarSolicitacao_QdoRascunhoExluirDespesa(string usuario, string statusAtual, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN05 - editarSolicitacao_QdoRascunhoExluirDespesa", @__tags);
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
 testRunner.Given(string.Format("Que o usuário {0} esteja logado no sistema", usuario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 40
 testRunner.When(string.Format("Visualizar solicitação com status {0}", statusAtual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 41
 testRunner.And("Validar o valor total de despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 42
 testRunner.And("Excluir uma Despesa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 43
 testRunner.Then("Validar o valor total de despesas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("CN05 - editarSolicitacao_QdoRascunhoExluirDespesa, solicitante", new string[] {
                "Browser_Chrome"}, SourceLine=45)]
        public virtual void CN05_EditarSolicitacao_QdoRascunhoExluirDespesa_Solicitante()
        {
#line 38
this.CN05_EditarSolicitacao_QdoRascunhoExluirDespesa("solicitante", "rascunho", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
