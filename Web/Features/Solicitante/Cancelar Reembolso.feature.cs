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
    [TechTalk.SpecRun.FeatureAttribute("CN06 - Cancelar Reembolso", Description="\tFuncionalidade tem o objetivo de permitir que os colaboradores da prodesp cancel" +
        "e um reembolso", SourceFile="Features\\Solicitante\\Cancelar Reembolso.feature", SourceLine=1)]
    public partial class CN06_CancelarReembolsoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Cancelar Reembolso.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "CN06 - Cancelar Reembolso", "\tFuncionalidade tem o objetivo de permitir que os colaboradores da prodesp cancel" +
                    "e um reembolso", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("CN06 - cancelarReembolso_QdoDevolvidaPeloGestor", new string[] {
                "Browser_Chrome"}, SourceLine=4)]
        public virtual void CN06_CancelarReembolso_QdoDevolvidaPeloGestor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN06 - cancelarReembolso_QdoDevolvidaPeloGestor", new string[] {
                        "Browser_Chrome"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Que o usuário solicitante esteja logado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 7
 testRunner.When("Visualizar solicitação com status Devolvido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 8
 testRunner.And("Validar a mensagem O seu reembolso foi devolvido pelo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 9
 testRunner.And("Fechar modal de justificativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And("Clicar no botão Cancelar Reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.Then("Validar a mensagem Cancelar a solicitação de reembolso?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 12
 testRunner.And("Confirmar o cancelamento do reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
 testRunner.And("Validar a mensagem Reembolso cancelado com sucesso!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
 testRunner.And("Clicar no botao OK", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
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
