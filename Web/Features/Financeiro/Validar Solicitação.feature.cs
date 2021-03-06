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
namespace Reembolso.Features.Financeiro
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CN11 - Validar Reembolso", Description="Esta funcionalidade tem o objetivo de permitir que os colaboradores da Prodesp qu" +
        "e tenha credenciais de financeiro valide as solicitações de reembolso.", SourceFile="Features\\Financeiro\\Validar Solicitação.feature", SourceLine=0)]
    public partial class CN11_ValidarReembolsoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Validar Solicitação.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "CN11 - Validar Reembolso", "Esta funcionalidade tem o objetivo de permitir que os colaboradores da Prodesp qu" +
                    "e tenha credenciais de financeiro valide as solicitações de reembolso.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("CN11 - validarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Validar", new string[] {
                "Browser_Chrome"}, SourceLine=4)]
        public virtual void CN11_ValidarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Validar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN11 - validarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Validar", new string[] {
                        "Browser_Chrome"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Que o usuário Financeiro esteja logado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 7
 testRunner.And("Navegar até a pagina de Validar reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 8
 testRunner.When("selecionar uma solicitação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.And("Clicar no botão validar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And("Validar a mensagem Validar reembolso?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.And("Confirmar a validação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 12
 testRunner.And("Validar a mensagem Reembolso validado com sucesso!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
 testRunner.And("Fechar o modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
 testRunner.And("Clicar no botão Voltar da pagina Reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.Then("Verificar se na tabela Validar não consta a solicitação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("CN11 - validarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Devolver", new string[] {
                "Browser_Chrome"}, SourceLine=17)]
        public virtual void CN11_ValidarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Devolver()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CN11 - validarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Devolver", new string[] {
                        "Browser_Chrome"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("Que o usuário Financeiro esteja logado no sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 20
 testRunner.And("Navegar até a pagina de Validar reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 21
 testRunner.When("selecionar uma solicitação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 22
 testRunner.And("Clicar no botão Devolver", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 23
 testRunner.And("Validar a mensagem Justificativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 24
 testRunner.And("Inserir Justificativa Por favor, verifique a solicitação.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 25
 testRunner.And("Confirmar Devolução", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 26
 testRunner.And("Validar a mensagem Reembolso devolvido com sucesso!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
 testRunner.And("Fechar o modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 28
 testRunner.And("Clicar no botão Voltar da pagina Reembolso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.Then("Verificar se na tabela Validar não consta a solicitação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
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
