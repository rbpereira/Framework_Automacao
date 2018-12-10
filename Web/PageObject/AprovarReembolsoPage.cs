using OpenQA.Selenium;
using Web.Comum;

namespace Web.PageObject
{
    public static class AprovarReembolsoPage
    {
        public static By TblReembolso()
        {
            By tbl = (By.TagName("table"));
            return tbl;
        }

        public static By BtnProximo()
        {
            By btn = By.XPath("//a[contains(@class,'ui-paginator-next')]");
            return btn;
        }

        public static By BtnAprovar()
        {
            By btn = By.XPath("//span[text()='Aprovar']");
            return btn;
        }

        public static By BtnCancelar()
        {
            By btn = By.XPath("//span[text()='Cancelar']");
            return btn;
        }
        public static By BtnReprovar()
        {
            By btn = By.XPath("//span[text()='Reprovar']");
            return btn;
        }

        public static By BtnDevolver()
        {
            By btn = By.XPath("//span[text()='Devolver']");
            return btn;
        }

        public static By BtnFecharModal()
        {
            By btn = By.XPath("//*[contains(@class, 'fa-w-11')]");
            return btn;
        }

        public static By BtnFecharModalJustificativa()
        {
            By btn = By.XPath("//*[contains(@class, 'pi pi-times')]");
            return btn;
        }

        public static By ModalMensagemValidacao()
        {
            By modal = By.XPath("//*/p-dialog/*");
            return modal;
        }

        public static By TxtJustificativa()
        {
            By txt = By.XPath("//*/p-dialog/div/div[2]/div/input");
            return txt;
        }

        public static By BtnAprovarSelecionados()
        {
            By btn = By.XPath("//*[text()='Aprovar selecionados']");
            return btn;
        }
    }
}
