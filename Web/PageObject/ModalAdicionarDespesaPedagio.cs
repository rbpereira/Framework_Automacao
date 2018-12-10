using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class ModalAdicionarDespesaPedagio
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
        public static By TxtCNPJ()
        {
            By txt = (By.Id("campoCnpjEstabelecimentoDespesa"));
            return txt;
        }

        public static By TxtPracaPedagio()
        {
            By txt = (By.Id("campoPracaPedagio"));
            return txt;
        }

        public static By BtnSalvar()
        {
            By Salvar = (By.XPath("//button[text() = 'Salvar' or text()='SALVAR']"));
            return Salvar;
        }

        public static By IconeDropDownOrigem()
        {
            By dropdown = (By.XPath("//*/div[3]/p-dropdown/div/div[3]/span"));
            return dropdown;
        }

        public static By IconeDropDownDestino()
        {
            By dropdown = (By.XPath("//*/div[4]/p-dropdown/div/div[3]/span"));
            return dropdown;
        }

        public static By TxtValor()
        {
            By Valor = (By.Id("campoValorDespesa"));
            return Valor;
        }

        public static By BtnAnexarComprovante()
        {
            //;By AnexarComprovante = (By.ClassName("ng-star-inserted"));
            By AnexarComprovante = (By.XPath("//*/p-fileupload/span/input"));
            return AnexarComprovante;
        }

        public static By BtnRemoverAnexo()
        {
            By Salvar = (By.XPath("//span[text() = 'Remover Anexo']"));
            return Salvar;
        }
    }
}
