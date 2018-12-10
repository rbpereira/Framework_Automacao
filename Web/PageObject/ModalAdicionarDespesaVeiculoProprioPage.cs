using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class ModalAdicionarDespesaVeiculoProprioPage
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

        public static By BtnSalvar()
        {
            By Salvar = (By.XPath("//button[text() = 'Salvar' or text()='SALVAR']"));
            return Salvar;
        }

        public static By IconeDropDownOrigem()
        {
            By dropdown = (By.XPath("//p-dropdown[contains(@formcontrolname, 'origem')]"));
            return dropdown;
        }

        public static By IconeDropDownDestino()
        {
            By dropdown = (By.XPath("//p-dropdown[contains(@formcontrolname, 'destino')]"));
            return dropdown;
        }

        public static By TxtOutroEnderecoOrigem()
        {
            By txt = By.XPath("//*[@id='campoEnderecoOrigemVeiculoDespesa']/span/input");
            return txt;
        }
        public static By TxtOutroEnderecoDestino()
        {
            By txt = By.XPath("//*[@id='campoEnderecoDestinoVeiculoDespesa']/span/input");
            return txt;
        }

        public static By BtnPesquisar()
        {
            By btn = (By.XPath("//button[text() = 'Pesquisar']"));
            return btn;
        }

    }
}
