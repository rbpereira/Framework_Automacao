using OpenQA.Selenium;

namespace Web.PageObject
{
    public static class SolicitarReembolsoPage
    {
        public static By CboMotivo()
        {
            By Motivo = (By.Id("campoMotivoReembolso"));
            return Motivo;
        }

        public static By TxtDescricao()
        {
            By Descricao = (By.Id("campoDescricaoSolicitacao"));
            return Descricao;
        }

        public static By TxtInformeMotivo()
        {
            By Motivo = (By.Id("campoOutroMotivoSolicitacao"));
            return Motivo;
        }

        public static By RdbSelectRecursoSim()
        {
            By RecursoSim = (By.Id("boxRadioSelRecursoSim"));
            return RecursoSim;
        }

        public static By RdbSelectRecursoNao()
        {
            By RecursoNao = (By.Id("boxRadioSelRecursoNao"));
            return RecursoNao;
        }

        public static By OptRecurso()
        {
            By Recurso = (By.Id("campoRecursoReembolso"));
            return Recurso;
        }

        public static By TxtCodDescricao()
        {
            By CodDescricao = (By.XPath("//input[@type='text'][contains(@formcontrolname,'codDescRecurso')]"));
            return CodDescricao;
        }


        public static By BtnAdicionarDespesa()
        {
            //By AdicionarDespesa = (By.XPath("//a[@class='lnkModal lnkAdd'][contains(@class,'lnkModal lnkAdd')]"));
            By AdicionarDespesa = By.ClassName("lnkAdd");
            return AdicionarDespesa;
        }

        public static By BtnSalvarComoRascunho()
        {
            By SalvarComoRascunho = By.XPath("//button[text()='Salvar como rascunho']");
            return SalvarComoRascunho;
        }

        public static By TblDespesas()
        {
            By tbl = By.TagName("table");
            return tbl;
        }

        public static By LblTotalReembolso()
        {
            By lbl = By.ClassName("boxValorSolicitacao");
            return lbl;
        }

        public static By BtnExcluirDespesa()
        {
            By btn = By.ClassName("icoExcluir");
            return btn;
        }

        public static By BtnVoltar()
        {
            By btn = By.XPath("//button[text()='VOLTAR' or text()='Voltar']");
            return btn;
        }

        public static By BtnExcluirReembolso()
        {
            By btn = (By.XPath("//button[text() = 'Excluir reembolso']"));
            return btn;
        }

        public static By BtnEnviarParaAprovacao()
        {
            By btn = By.XPath("//button[text()='Enviar para aprovação']");
            return btn;
        }

        public static By BtnExcluir()
        {
            By btn = By.XPath("//button/span[text() = 'EXCLUIR' or text() = 'Excluir']");
            //By btn = By.XPath("//*/p-footer/div/p-button[2]/button");
            return btn;
        }

        public static By BtnCancelar()
        {
            By btn = By.XPath("//span[text() = 'CANCELAR' or text() = 'Cancelar']");
            return btn;
        }

        public static By BtnOK()
        {
            By btn = By.XPath("//span[text() = 'OK' or text()= 'Ok']");
            return btn;
        }

        public static By MsgReembolsoExcluidoComSucesso()
        {
            By btn = By.XPath("//span[text() = 'Reembolso excluído com sucesso!']");
            return btn;
        }

        public static By MsgCancelarASolicitacaoReembolso()
        {
            By btn = By.XPath("//p[text() = 'Cancelar a solicitação de reembolso?']");
            return btn;
        }

        public static By BtnEnviar()
        {
            By btn = By.XPath("//span[text() = 'ENVIAR' or text() = 'Enviar']");
            return btn;
        }

        public static By BtnCancelarReembolso()
        {
            By btn = By.XPath("//button[text() = 'Cancelar reembolso']");
            return btn;
        }

        public static By DropDowMotivo()
        {
            By btn = By.XPath("//span[contains(@class,'ui-dropdown-trigger-icon')]");
            return btn;
        }

        public static By DropDownRecurso()
        {
            By btn = By.XPath("//*[@id='campoRecursoReembolso']/*//span");
            return btn;
        }

        public static By BtnSim()
        {
            By btn = By.XPath("//span[text() = 'SIM' or text() = 'Sim']");
            return btn;
        }

        public static By BtnNao()
        {
            By btn = By.XPath("//span[text() = 'Não' or text() = 'NÃO']");
            return btn;
        }

        public static By BtnEnviarNovamente()
        {
            By btn = By.XPath("//*/button[2]");
            return btn;
        }

        public static By BtnSubmitLogin()
        {
            By btn = By.ClassName("btnSubmitLogin");
            return btn;
        }
    }
}
