using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class ModalAdicionarDespesaMetroTremPage
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
            By EstacaoOrigem = (By.XPath("/html/body/ngb-modal-window[2]/div/div/app-modal-metro-trem/div/div/div[2]/form/div[3]/p-dropdown/div/label"));
            return EstacaoOrigem;
        }

        public static By TxtEstacaoDestino()
        {
            By EstacaoDestino = (By.XPath("/html/body/ngb-modal-window[2]/div/div/app-modal-metro-trem/div/div/div[2]/form/div[4]/p-dropdown/div/label"));
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
            By Salvar = (By.XPath("//*[text() = 'Salvar' or text()='SALVAR']"));
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

    }
}
