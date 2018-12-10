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
namespace Web.Features.Solicitante
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CN10 - Excluir Solicitacao", Description="\tFuncionalidade tem o objetivo de permitir que os colaboradores da Prodesp exclua" +
        " solicitações criadas.", SourceFile="Features\\Solicitante\\Excluir Solicitacao.feature", SourceLine=1)]
    public partial class CN10_ExcluirSolicitacaoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Excluir Solicitacao.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "CN10 - Excluir Solicitacao", "\tFuncionalidade tem o objetivo de permitir que os colaboradores da Prodesp exclua" +
                    " solicitações criadas.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void CN10_ExcluirSolicitacao_QdoEmRascunho(string usuario, string mensageminterrogativa, string mensagemconfirmacao, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN10 - excluirSolicitacao_QdoEmRascunho", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("Que o usuário {0} esteja logado no sistema", usuario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.When(string.Format("Visualizar solicitação com status {0}", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.And("Clicar no botão Excluir Reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.Then(string.Format("É apresentanda a mensagem {0}", mensageminterrogativa), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 11
 testRunner.And("Clicar no botão Excluir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 12
 testRunner.And(string.Format("Validar mensagem {0} de confirmação", mensagemconfirmacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
 testRunner.And("Clicar em OK", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
 testRunner.And("Verificar se o reembolso foi deletado da tabela de meus reembolsos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("CN10 - excluirSolicitacao_QdoEmRascunho, solicitante", new string[] {
                "Browser_Chrome"}, SourceLine=17)]
        public virtual void CN10_ExcluirSolicitacao_QdoEmRascunho_Solicitante()
        {
#line 6
this.CN10_ExcluirSolicitacao_QdoEmRascunho("solicitante", "Excluir a solicitação de reembolso?", "Reembolso excluído com sucesso!", "rascunho", ((string[])(null)));
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
