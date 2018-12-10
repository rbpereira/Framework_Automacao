using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Web.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Web.Comum
{
    public class FuncoesAplicacao : Funcionalidades
    {
        public static void SelecionarMotivo(string Origem)
        {
            Thread.Sleep(600);
            Driver.FindElement(SolicitarReembolsoPage.DropDowMotivo()).Click();
            Thread.Sleep(600);
            Driver.FindElement(By.XPath("//Span[text()='" + Origem + "']")).Click();
            Thread.Sleep(600);
        }

        public static void SelecionarRecurso(string recurso)
        {
            Thread.Sleep(600);
            Driver.FindElement(SolicitarReembolsoPage.DropDownRecurso()).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//Span[text()='" + recurso + "']")).Click();
            Thread.Sleep(500);
        }

        public static void SelecionarOrigem(string Origem, By Locator)
        {
            System.Threading.Thread.Sleep(500);
            Driver.FindElement(ModalAdicionarDespesaVeiculoProprioPage.IconeDropDownOrigem()).Click();
            Thread.Sleep(500);
            Driver.FindElement(By.XPath("//Span[text()='" + Origem + "']")).Click();
            Thread.Sleep(500);
            if (Origem == "Outro")
            {
                string lstOrigem = Listas.EnderecosDeSp();
                EnviarTexto(lstOrigem + Keys.Space + Keys.Backspace + Keys.Space, Locator);
                Thread.Sleep(500);
                EnviarTexto(lstOrigem + Keys.Space + Keys.Backspace + Keys.Space, Locator);

                if (Driver.FindElements(By.ClassName("boxSelecaoDespesa"))[1].FindElement(By.ClassName("nomeDespesa")).Text.Contains("Veículo Próprio"))
                {
                    Thread.Sleep(500);
                    EnviarTexto(Keys.Tab, Paginas.Pagina());
                    Driver.FindElement(By.XPath("//Span[text()='" + lstOrigem + "']")).Click();
                    Thread.Sleep(500);
                    IWebElement BtnPesquisar = Driver.FindElement(ModalAdicionarDespesaVeiculoProprioPage.BtnPesquisar());

                    if (BtnPesquisar.Enabled && BtnPesquisar.Displayed)
                    {
                        BtnPesquisar.Click();
                    }
                    else
                    {
                        Assert.Fail("O botão Pesquisar não esta disponível.");
                    }
                }
            }
        }

        public static void SelecionarDestino(string Destino, By Locator)
        {
            bool Outro = true;
            Driver.FindElement(ModalAdicionarDespesaVeiculoProprioPage.IconeDropDownDestino()).Click();
            Thread.Sleep(500);
            string lstDestino = (Destino == null || Destino == "" || Destino.Contains("destino") ? Listas.EnderecosDeSp() : Destino);
            var texto = Driver.FindElements(By.TagName("ul"));
            int secondsToWait = 60;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, secondsToWait));

            for (int i = 0; i < texto.Count; i++)
            {
                if (texto[i].Text.Contains(lstDestino) && lstDestino != "Outro")
                {
                    Outro = false;
                }
            }

            if (Outro == true)
            {
                Driver.FindElement(By.XPath("//Span[text() = 'Outro']")).Click();


                EnviarTexto(lstDestino + Keys.Space + Keys.Backspace + Keys.Space, Locator);
                Thread.Sleep(500);
                EnviarTexto(lstDestino + Keys.Space + Keys.Backspace + Keys.Space, Locator);

                if (Driver.FindElements(By.ClassName("boxSelecaoDespesa"))[1].FindElement(By.ClassName("nomeDespesa")).Text.Contains("Veículo Próprio"))
                {
                    Thread.Sleep(500);
                    EsperarObjetoCarregar((By.XPath("//Span[text()='" + lstDestino + "']")));
                    Driver.FindElement(By.XPath("//Span[text()='" + lstDestino + "']")).Click();
                    //wait.Until(d => d.FindElement(ModalAdicionarDespesaVeiculoProprioPage.BtnPesquisar()).Enabled);
                    Thread.Sleep(500);
                    IWebElement BtnPesquisar = Driver.FindElement(ModalAdicionarDespesaVeiculoProprioPage.BtnPesquisar());

                    if (BtnPesquisar.Enabled && BtnPesquisar.Displayed)
                    {
                        BtnPesquisar.Click();

                        wait.Until(d => d.FindElement(By.XPath("//app-modal-veiculo//*/form/*/div[1]/span")).Text != "0");
                    }
                    else
                    {
                        Assert.Fail("O botão Pesquisar não esta disponível.");
                    }
                }
            }
            else
            {
                Driver.FindElement(By.XPath("//Span[text()='" + lstDestino + "']")).Click();
                Thread.Sleep(500);
            }
        }

        public static void PesquisarValorTabela(By Locator, string mensagem)
        {
            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());

            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");

            while (obj != ("-1"))
            {
                obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
                Clicar(MeusReembolsosPage.BtnProximo());
                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            }
            var rows = table.FindElements(By.TagName("tr")).Count;

            //for (int i = 1; i < rows; i++)
            //{
            var NroReembolso = table.FindElements(By.XPath("//*/table/tbody/tr[" + (rows - 1) + "]/td[1]"));
            var dtSolicitacao = table.FindElements(By.XPath("//*/table/tbody/tr[" + (rows - 1) + "]/td[2]"));
            var descricao = table.FindElements(By.XPath("//*/table/tbody/tr[" + (rows - 1) + "]/td[3]"));
            var status = table.FindElements(By.XPath("//*/table/tbody/tr[" + (rows - 1) + "]/td[5]"));


            switch (status[0].Text.ToUpper())
            {
                case "AGUARDANDO VALIDAÇÃO COORDENADOR":
                    if (descricao[0].Text.Contains(mensagem) && (NroReembolso[0].Text.Length > 1))
                    {
                        Assert.True(true);
                        return;
                    }
                    break;
                case "AGUARDANDO APROVAÇÃO":
                    if (descricao[0].Text.Contains(mensagem) && (NroReembolso[0].Text.Length > 1))
                    {
                        Assert.True(true);
                        return;
                    }
                    break;
                case "RASCUNHO":
                    if (descricao[0].Text.Contains(mensagem))
                    {
                        Assert.True(true);
                        return;
                    }
                    break;
                case "AGUARDANDO VERIFICAÇÃO DO FINANCEIRO":
                    if (descricao[0].Text.Contains(mensagem) && (NroReembolso[0].Text.Length > 1))
                    {
                        Assert.True(true);
                        return;
                    }
                    break;
                case "DEVOLVIDO (GESTOR)":
                    if (descricao[0].Text.Contains(mensagem) && (NroReembolso[0].Text.Length > 1))
                    {
                        Assert.True(true);
                        return;
                    }
                    break;
            }

            Assert.Fail("A solicitação não foi encontrada.");
        }

        public static void InserirDespesaEstacionamento(string origem, string destino, string comprovante)
        {
            Clicar(ModalAdicionarDespesaPage.BtnEstacionamento());
            EnviarTexto(strDataHora.ToString("dd/MM/yyyy"), ModalAdicionarDespesaEstacionamentoPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaEstacionamentoPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Control + "a", ModalAdicionarDespesaEstacionamentoPage.TxtHorario());
            Driver.FindElement(ModalAdicionarDespesaEstacionamentoPage.TxtHorario()).SendKeys(Keys.Delete);
            EnviarTexto(strDataHora.ToString("HH:mm"), ModalAdicionarDespesaEstacionamentoPage.TxtHorario());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaEstacionamentoPage.TxtHorario());
            EnviarTexto(GeradorCpfCnpj.GerarCnpj(), ModalAdicionarDespesaEstacionamentoPage.TxtCnpjEstabelecimento());
            Clicar(ModalAdicionarDespesaEstacionamentoPage.RdbNotaFiscal());
            EnviarTexto(GerarNumeros.GerarNumerosAleatorios(), ModalAdicionarDespesaEstacionamentoPage.TxtNumeroNotaFiscal());
            EnviarTexto(GerarNumeros.GerarValoresAleatorios(), ModalAdicionarDespesaEstacionamentoPage.TxtValorDaDespesa());
            EnviarTexto(comprovante == "" ? strComprovante : comprovante, ModalAdicionarDespesaEstacionamentoPage.BtnAnexarComprovante());
            EsperarObjetoCarregar(ModalAdicionarDespesaEstacionamentoPage.BtnRemoverAnexo());
        }

        public static void InserirDespesaMetroTrem(string origem, string destino)
        {
            Clicar(ModalAdicionarDespesaPage.BtnMetroTrem());
            EnviarTexto(strDataHora.ToString("dd/MM/yyyy"), ModalAdicionarDespesaMetroTremPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaMetroTremPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Control + "a", ModalAdicionarDespesaMetroTremPage.TxtHorario());
            Driver.FindElement(ModalAdicionarDespesaMetroTremPage.TxtHorario()).SendKeys(Keys.Delete);
            EnviarTexto(strDataHora.ToString("HH:mm"), ModalAdicionarDespesaMetroTremPage.TxtHorario());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaMetroTremPage.TxtHorario());
            //selecionar Origem
            SelecionarOrigem(origem, ModalAdicionarDespesaMetroTremPage.IconeDropDownOrigem());
            //Selecionar Destino
            SelecionarDestino(destino, ModalAdicionarDespesaMetroTremPage.IconeDropDownDestino());
            Clicar(ModalAdicionarDespesaMetroTremPage.ChkIdaVolta());
            EnviarTexto(GerarNumeros.GerarValoresAleatorios(), ModalAdicionarDespesaMetroTremPage.TxtValor());
        }

        public static void InserirDespesaOnibus(string origem, string destino)
        {
            Clicar(ModalAdicionarDespesaPage.BtnOnibus());
            EnviarTexto(strDataHora.ToString("dd/MM/yyyy"), ModalAdicionarDespesaOnibusPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaOnibusPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Control + "a", ModalAdicionarDespesaOnibusPage.TxtHorario());
            Driver.FindElement(ModalAdicionarDespesaOnibusPage.TxtHorario()).SendKeys(Keys.Delete);
            EnviarTexto(strDataHora.ToString("HH:mm"), ModalAdicionarDespesaOnibusPage.TxtHorario());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaOnibusPage.TxtHorario());
            //selecionar Origem
            SelecionarOrigem(origem, ModalAdicionarDespesaOnibusPage.TxtOutroEnderecoOrigem());
            //Selecionar Destino
            SelecionarDestino(destino, ModalAdicionarDespesaOnibusPage.TxtOutroEnderecoDestino());
            Clicar(ModalAdicionarDespesaOnibusPage.ChkIdaVolta());
            EnviarTexto(GerarNumeros.GerarValoresAleatorios(), ModalAdicionarDespesaOnibusPage.TxtValor());
        }

        public static void InserirDespesaPedagio(string comprovante)
        {
            Clicar(ModalAdicionarDespesaPage.BtnPedagio());
            EnviarTexto(strDataHora.ToString("dd/MM/yyyy"), ModalAdicionarDespesaPedagio.TxtDataDaDespesa());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaPedagio.TxtDataDaDespesa());
            EnviarTexto(Keys.Control + "a", ModalAdicionarDespesaPedagio.TxtHorario());
            Driver.FindElement(ModalAdicionarDespesaPedagio.TxtHorario()).SendKeys(Keys.Delete);
            EnviarTexto(strDataHora.ToString("HH:mm"), ModalAdicionarDespesaPedagio.TxtHorario());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaPedagio.TxtHorario());
            EnviarTexto(GeradorCpfCnpj.GerarCnpj(), ModalAdicionarDespesaPedagio.TxtCNPJ());
            EnviarTexto(Listas.Pedagios(), ModalAdicionarDespesaPedagio.TxtPracaPedagio());
            EnviarTexto(GerarNumeros.GerarNumerosAleatorios(), ModalAdicionarDespesaPedagio.TxtValor());
            EnviarTexto(GerarNumeros.GerarValoresAleatorios(), ModalAdicionarDespesaPedagio.TxtValor());
            EnviarTexto(comprovante == "" ? strComprovante : comprovante, ModalAdicionarDespesaEstacionamentoPage.BtnAnexarComprovante());
            EsperarObjetoCarregar(ModalAdicionarDespesaEstacionamentoPage.BtnRemoverAnexo());
        }

        public static void InserirDespesaTaxi(string origem, string destino, string comprovante)
        {
            Clicar(ModalAdicionarDespesaPage.BtnTaxi());
            EnviarTexto(strDataHora.ToString("dd/MM/yyyy"), ModalAdicionarDespesaTaxiPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaTaxiPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Control + "a", ModalAdicionarDespesaTaxiPage.TxtHorario());
            Driver.FindElement(ModalAdicionarDespesaTaxiPage.TxtHorario()).SendKeys(Keys.Delete);
            EnviarTexto(strDataHora.ToString("HH:mm"), ModalAdicionarDespesaTaxiPage.TxtHorario());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaTaxiPage.TxtHorario());
            Clicar(ModalAdicionarDespesaTaxiPage.RdbTaxiComum());
            //selecionar Origem
            SelecionarOrigem(origem == "" || origem.Contains("origem") ? Listas.Locais() : origem, ModalAdicionarDespesaTaxiPage.TxtEnderecoOrigem());
            //Selecionar Destino
            SelecionarDestino(destino == "" || destino.Contains("destino") ? Listas.Locais() : destino, ModalAdicionarDespesaTaxiPage.TxtEnderecoDestino());
            EnviarTexto(GerarNumeros.GerarValoresAleatorios(), ModalAdicionarDespesaTaxiPage.TxtValor());
            EnviarTexto(comprovante == "" ? strComprovante : comprovante, ModalAdicionarDespesaEstacionamentoPage.BtnAnexarComprovante());
            EsperarObjetoCarregar(ModalAdicionarDespesaTaxiPage.BtnRemoverAnexo());
            Driver.FindElement(Paginas.Pagina()).SendKeys(Keys.PageDown);
        }

        public static void InserirDespesaVeiculoProprio(string origem, string destino)
        {
            Clicar(ModalAdicionarDespesaPage.BtnVeiculoProprio());
            EnviarTexto(strDataHora.ToString("dd/MM/yyyy"), ModalAdicionarDespesaVeiculoProprioPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaVeiculoProprioPage.TxtDataDaDespesa());
            EnviarTexto(Keys.Control + "a", ModalAdicionarDespesaVeiculoProprioPage.TxtHorario());
            Driver.FindElement(ModalAdicionarDespesaVeiculoProprioPage.TxtHorario()).SendKeys(Keys.Delete);
            EnviarTexto(strDataHora.ToString("HH:mm"), ModalAdicionarDespesaVeiculoProprioPage.TxtHorario());
            EnviarTexto(Keys.Tab, ModalAdicionarDespesaVeiculoProprioPage.TxtHorario());
            //selecionar Origem
            SelecionarOrigem(Listas.Locais(), ModalAdicionarDespesaVeiculoProprioPage.TxtOutroEnderecoOrigem());
            //Selecionar Destino
            SelecionarDestino(destino, ModalAdicionarDespesaVeiculoProprioPage.TxtOutroEnderecoDestino());
            Driver.FindElement(Paginas.Pagina()).SendKeys(Keys.PageDown);
        }

        public static void ValidarValorTotalDespesas(By Locator)
        {
            EnviarTexto(Keys.PageDown, Paginas.Pagina());
            //var obj = CapturarTexto(SolicitarReembolsoPage.LblTotalReembolso());
            var obj = Driver.FindElement(SolicitarReembolsoPage.LblTotalReembolso()).FindElement(By.TagName("span")).Text;
            var TotalReembolso = float.Parse(obj.Substring(3).Replace(".", ""));

            var table = Driver.FindElement(Locator);
            var rows = table.FindElements(By.TagName("tr")).Count;
            float ValorTotal = 0;
            var Coluna = table.FindElements(By.XPath("//*/table/tbody/tr[1]/td[1]"));

            if (Coluna[0].Text.Contains("Nenhuma despesa adicionada"))
            {
                ValorTotal = 0;
            }
            else
            {
                for (int i = 1; i < rows; i++)
                {
                    Coluna = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[4]"));
                    var strValor = (Coluna[0].Text).Substring(3).Replace(".", "");
                    ValorTotal = ValorTotal + float.Parse(strValor);
                }
            }

            Assert.IsTrue(ValorTotal == TotalReembolso, "O valor total do reembolso não está correto, por favor verificar valor.");

        }

        public static void VisualizarReembolsos(string status, By Locator)
        {
            //wait.Until(d => d.FindElement(By.XPath("//*/table/tbody/tr[1]/td[1]")).Text.Equals("Você não tem nenhum reembolso pendente."));

            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            Thread.Sleep(1000);
            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var strtexto = table.FindElements(By.XPath("//*/table/tbody/tr[1]/td[1]"));
            var texto = strtexto[0].Text;


            var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
            int i = 1;

            while (obj != ("-1") || i == 1)
            {
                var rows = table.FindElements(By.TagName("tr")).Count;

                for (i = 1; i < rows; i++)
                {
                    var NroReembolso = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[1]"));
                    NumeroReembolso = NroReembolso[0].Text;

                    var dtSolicitacao = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[2]"));
                    strDataSolicitacao = dtSolicitacao[0].Text;

                    var desc = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[3]"));
                    strDescricao = desc[0].Text;

                    var valor = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[4]"));
                    var strValor = (valor[0].Text);

                    var colstatus = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[5]"));
                    strStatus = colstatus[0].Text;

                    if (strStatus.ToUpper().Contains(status.ToUpper()))
                    {
                        Clicar(By.XPath("//*/table/tbody/tr[" + i + "]/td[5]"));
                        return;
                    }
                }

                obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
                Clicar(MeusReembolsosPage.BtnProximo());
                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            }

            Assert.Fail("Não foi encontrada a solicitação com status " + status);
            return;
        }

        public static void ValidarStatus(string status)
        {
            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            Thread.Sleep(3000);
            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
            //NumeroReembolso;

            while (obj != ("-1"))
            {
                var rows = table.FindElements(By.TagName("tr")).Count;

                for (int i = 1; i < rows; i++)
                {
                    var NroReembolso = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[1]"));
                    var dtSolicitacao = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[2]"));
                    var descricao = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[3]"));
                    var valor = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[4]"));
                    var Status = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[5]"));

                    if (status == Status[0].Text && strDataSolicitacao == dtSolicitacao[0].Text && NroReembolso[0].Text.Length > 1)
                    {
                        Clicar(By.XPath("//*/table/tbody/tr[" + i + "]/td[5]"));
                        return;
                    }
                }

                obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
                Clicar(MeusReembolsosPage.BtnProximo());
                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            }

            Assert.Fail("Não foi encontrada a solicitação com status " + status);
            return;
        }
       

        public static void PesquisarReembolsoExcluido()
        {
            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");

            while (obj != ("-1"))
            {

                var rows = table.FindElements(By.TagName("tr")).Count;

                for (int i = 2; i < rows; i++)
                {
                    var dtSolicitacao = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[2]"));
                    var descricao = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[3]"));

                    if ((strDataSolicitacao == dtSolicitacao[0].Text) && (strDescricao == descricao[0].Text))
                    {
                        Clicar(By.XPath("//*/table/tbody/tr[" + i + "]/td[5]"));
                        Assert.Fail("O reembolso não foi deletado.");
                        return;
                    }
                }
                obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
                Clicar(MeusReembolsosPage.BtnProximo());
                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            }
        }

        public static string SelecionarReembolso(int quantidade)
        {
            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            EsperarTabelaCarregar();
            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var rows = table.FindElements(By.TagName("tr")).Count;
            var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
            string NumReembolso = "";

            if (quantidade <= rows && quantidade > 0)
            {
                for (int i = 1; i <= quantidade; i++)
                {
                    var selectCheckbox = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[1]"))[0].FindElement(By.TagName("div"));
                    selectCheckbox.Click();
                    NumReembolso = table.FindElement(By.XPath("//*/table/tbody/tr[" + i + "]/td[1]")).ToString();
                    ListNumeroReembolso.Add(table.FindElement(By.XPath("//*/table/tbody/tr[" + i + "]/td[2]")).Text.ToString());
                }

                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            }
            else
            {
                Assert.Fail("Não possui o número de reembolsos para aprovação.");
            }

            return NumReembolso;
        }

        public static void VisualizarAprovarReprovarDevolverReembolso(string acao)
        {
            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var rows = table.FindElements(By.TagName("tr")).Count;

            if (rows > 0)
            {
                for (int i = 1; i <= rows; i++)
                {
                    var selectCheckbox = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[1]"))[0].FindElements(By.TagName("div"));
                    var attributes = selectCheckbox[2].GetAttribute("class");

                    if (attributes.Contains("active"))
                    {
                        switch (acao.ToUpper())
                        {
                            case "VISUALIZAR":
                                var btnVizualizar = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[7]"))[0].FindElement(By.TagName("div"));
                                return;
                            case "APROVAR":
                                var btnAprovar = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[8]"))[0].FindElements(By.TagName("fa-icon"));
                                btnAprovar[0].Click();
                                return;
                            case "REPROVAR":
                                table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[9]"))[0].FindElement(By.TagName("svg")).Click();
                                return;
                            case "DEVOLVER":
                                table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[10]"))[0].FindElement(By.TagName("svg")).Click();
                                return;
                        }
                    }
                }

                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            }
            else
            {
                Assert.Fail("Não possui reembolsos selecionados.");
                return;
            }
        }

        public static void PesquisarReembolsoTlbAprovar()
        {
            Esperar();
            foreach (string element in ListNumeroReembolso)
            {
                EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
                var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
                var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");

                while (obj != ("-1"))
                {

                    var rows = table.FindElements(By.TagName("tr")).Count;

                    for (int i = 2; i < rows; i++)
                    {
                        var NSolicitacao = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[2]"));


                        if ((element == NSolicitacao[0].Text))
                        {
                            Clicar(By.XPath("//*/table/tbody/tr[" + i + "]/td[5]"));
                            Assert.Fail("O reembolso não foi deletado.");
                            return;
                        }
                    }
                    obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
                    Clicar(MeusReembolsosPage.BtnProximo());
                    EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
                }
            }
        }

        public static void SelecionarReembolsoTblValidar()
        {
            Esperar();

            EsperarObjetoCarregar(MeusReembolsosPage.CorpoTabela());
            EsperarTabelaCarregar();
            var table = Driver.FindElement(MeusReembolsosPage.TblReembolsos());
            var obj = Driver.FindElement(MeusReembolsosPage.BtnProximo()).GetAttribute("tabindex");
            var rows = table.FindElements(By.TagName("tr")).Count;

            if (rows > 1)
            {
                for (int i = 1; i < rows; i++)
                {
                    NumeroReembolso = table.FindElements(By.XPath("//*/table/tbody/tr[" + i + "]/td[1]"))[0].Text;


                    if (NumeroReembolso.Length > 0)
                    {
                        Clicar(By.XPath("//*/table/tbody/tr[" + i + "]/td[8]/img"));
                        return;
                    }
                }
            }
            else
            {
                Assert.Fail("Tabela não contém solicitações para aprovar/devolver.");
            }
        }

        public static int ContarQtdeLinhasTabela()
        {
            var table = Driver.FindElement(MeusReembolsosPage.CorpoTabela());
            int rows = table.FindElements(By.TagName("tr")).Count;

            return rows;
        }
    }
}
