using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class MeusReembolsosPage
    {
        public static By BtnSolicitarReembolso()
        {
            By SolicitarReembolso = (By.ClassName("lnkModal"));
            return SolicitarReembolso;
        }

        public static By TxtPesquisar()
        {
            By Pesquisar = (By.ClassName("input-sm"));
            return Pesquisar;
        }

        public static By TblReembolsos()
        {
            By tabela = By.TagName("table");
            return tabela;
        }

        public static By CorpoTabela()
        {
            By body = By.TagName("tbody");
            return body;
        }

        public static By TabelaSemReembolso()
        {
            By tbl = By.XPath("//*/table/tbody/tr/td");
            return tbl;
        }

        public static By BtnPaginacao()
        {
            By tabela = By.XPath("//a[contains(@class,'ui-paginator-page')]");
            return tabela;
        }

        public static By BtnProximo()
        {
            By btn = By.XPath("//a[contains(@class,'ui-paginator-next')]");
            return btn;
        }

        public static By CboExibirRegistrosPorPagina()
        {
            By cbo = By.XPath("//*/select");
            return cbo;
        }

        public static By ModalJustificativa()
        {
            By modal = (By.XPath("//*/p-dialog/div"));
            return modal;
        }

        public static By ImgIconeDinheiro()
        {
            By img = By.XPath("//*/table/tbody/tr/td/img");
            return img;
        }

    }
}
