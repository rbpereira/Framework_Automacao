using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class ModalAdicionarDespesaEstacionamentoPage
    {
        public static By TxtDataDaDespesa()
        {
            //By DataDaDespesa = By.XPath("//input[contains(@class, 'ng-tns-c4-0')]");
            By DataDaDespesa = By.XPath("//*/p-calendar/span/input");
            return DataDaDespesa;
        }

        public static By TxtHorario()
        {
            //By Horario = By.XPath("//input[contains(@class, 'ng-tns-c4-1')]");
            By Horario = By.XPath("//*/div[2]/p-calendar/span/input");
            return Horario;
        }

        public static By TxtCnpjEstabelecimento()
        {
            By CnpjEstabelecimento = (By.Id("campoCnpjEstabelecimentoDespesa"));
            return CnpjEstabelecimento;
        }

        public static By RdbReciboProvisorioDeServico()
        {
            By ReciboProvisorioDeServico = (By.Id("boxRadioSelRps"));
            return ReciboProvisorioDeServico;
        }

        public static By RdbNotaFiscal()
        {
            By NotaFiscal = (By.Id("boxRadioSelNF"));
            return NotaFiscal;
        }

        public static By TxtNumeroNotaFiscal()
        {
            By NumeroNotaFiscal = (By.Id("campoNfDespesa"));
            return NumeroNotaFiscal;
        }

        public static By TxtValorDaDespesa()
        {
            By ValorDaDespesa = (By.Id("campoValorDespesa"));
            return ValorDaDespesa;
        }

        public static By BtnAnexarComprovante()
        {
            //;By AnexarComprovante = (By.ClassName("ng-star-inserted"));
            By AnexarComprovante = (By.XPath("//*/p-fileupload/span/input"));
            return AnexarComprovante;
        }

        public static By BtnSalvar()
        {
            By Salvar = (By.XPath("//button[text() = 'Salvar' or text()='SALVAR']"));
            return Salvar;
        }

        public static By BtnRemoverAnexo()
        {
            By Salvar = (By.XPath("//span[text() = 'Remover Anexo']"));
            return Salvar;
        }
    }
}
