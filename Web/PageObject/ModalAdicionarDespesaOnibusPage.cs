using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class ModalAdicionarDespesaOnibusPage
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

        public static By TxtEstacaoOrigem()
        {
            By EstacaoOrigem = (By.XPath("//*[@class='ng-tns-c3-2 ui-dropdown-item ui-corner-all ng-star-inserted']"));
            return EstacaoOrigem;
        }

        public static By lblEstacaoOrigem()
        {
            By EstacaoOrigem = (By.XPath("//*[@class='ng-tns-c3-2 ui-dropdown-label ui-inputtext ui-corner-all ng-star-inserted']"));
            return EstacaoOrigem;
        }

        public static By TxtEstacaoDestino()
        {
            By EstacaoDestino = (By.XPath("//*[@class='ng-tns-c3-3 ui-dropdown-item ui-corner-all ng-star-inserted']"));
            return EstacaoDestino;
        }

        public static By lblEstacaoDestino()
        {
            By EstacaoDestino = (By.XPath("//*[@class='ng-tns-c3-2 ui-dropdown-label ui-inputtext ui-corner-all ng-star-inserted']"));
            return EstacaoDestino;
        }

        public static By ChkIdaVolta()
        {
            By IdaVolta = (By.Id("campoIdaVolta"));
            return IdaVolta;
        }

        public static By TxtValor()
        {
            By Valor = (By.Id("campoValorDespesa"));
            return Valor;
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
            By dropdown = (By.XPath("//*/div[5]/p-dropdown/div/div[3]/span"));
            return dropdown;
        }

        public static By TxtOutroEnderecoOrigem()
        {
            By txt = By.Id("campoEnderecoOrigemOnibusDespesa");
            return txt;
        }
        public static By TxtOutroEnderecoDestino()
        {
            By txt = By.Id("campoEnderecoDestinoOnibusDespesa");
            return txt;
        }

        public static By BtnSalvarEdicao()
        {
            By txt = By.XPath("//*/form/div/div[9]/button");
            return txt;
        }
    }
}
