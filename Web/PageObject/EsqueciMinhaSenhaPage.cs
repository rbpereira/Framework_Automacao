using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class EsqueciMinhaSenhaPage
    {
        public static By TxtSeuLogin()
        {
            By SeuLogin = (By.Id("username"));
            return SeuLogin;
        }

        public static By BtnEntrar()
        {
            By Entrar = (By.ClassName("btnSubmitLogin"));
            return Entrar;
        }

        public static By MsgErroLogin()
        {
            By MensagemErro = (By.ClassName("kc-feedback-text"));
            return MensagemErro;
        }
    }
}
