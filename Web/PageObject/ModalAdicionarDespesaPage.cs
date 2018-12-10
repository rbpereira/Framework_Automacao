using OpenQA.Selenium;
using Web.Comum;

namespace Web.PageObject
{
    public static class ModalAdicionarDespesaPage
    {
        public static By BtnEstacionamento()
        {
            By btn = (By.ClassName("opEstacionamento"));
            return btn;
        }

        public static By BtnMetroTrem()
        {
            By btn = (By.ClassName("opMetroTrem"));
            return btn;
        }

        public static By BtnOnibus()
        {
            By btn = (By.ClassName("opOnibus"));
            return btn;
        }

        public static By BtnPedagio()
        {
            By btn = (By.ClassName("opPedagio"));
            return btn;
        }

        public static By BtnTaxi()
        {
            By btn = (By.ClassName("opTaxi"));
            return btn;
        }

        public static By BtnVeiculoProprio()
        {
            By btn = (By.ClassName("opVeiculoProprio"));
            return btn;
        }

        public static By BtnClose()
        {
            By btn = (By.ClassName("btnClose"));
            return btn;
        }

        public static By BtnAlterar()
        {
            By btn = (By.ClassName("alterarDespesa"));
            return btn;
        }
    }
}
