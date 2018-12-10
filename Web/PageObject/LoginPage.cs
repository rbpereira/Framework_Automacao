using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class LoginPage
    {

        public static By TxtSeuLogin()
        {
            By SeuLogin = (By.Id("username"));
            return SeuLogin;
        }

        public static By TxtSuaSenha()
        {
            By SuaSenha = (By.Id("password"));
            return SuaSenha;
        }

        public static By BtnEntrar()
        {
            By Entrar = (By.Id("kc-login"));
            return Entrar;
        }

        public static By LnkEsqueciMinhaSenha()
        {
            By EsqueciMinhaSenha = (By.LinkText("Esqueci minha senha"));
            return EsqueciMinhaSenha;
        }

        public static By MsgErroLogin()
        {
            By MensagemErro = (By.XPath("/html/body"));
            return MensagemErro;
        }

        public static By MsgEntrarNoSistema()
        {
            By mensagem = (By.Id("kc-header-wrapper"));
            return mensagem;
        }


    }
}
