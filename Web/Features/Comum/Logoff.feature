Funcionalidade: CN02 - Logoff
	Funcionalidade destinada em fazer logof no sistema.

@Browser_Chrome
Esquema do Cenario: CN02 - logoff_MenuSuperiorDireito
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Clicar no menu com o icone da fotografica
	E Clicar no menu Sair
	Entao O usuário é desconectado do sistema retornando para tela de login <mensagem>
Exemplos: 
	| CasoTeste                          | usuario     | mensagem          |
	| logoffSolicitante_QdoUsuarioLogado | solicitante | ENTRAR NO SISTEMA |
	| logoffAprovador_QdoUsuarioLogado   | aprovador   | ENTRAR NO SISTEMA |
	| logoffSecretaria_QdoUsuarioLogado  | secretaria  | ENTRAR NO SISTEMA |
	| logoffFinanceiro_QdoUsuarioLogado  | financeiro  | ENTRAR NO SISTEMA |

@Browser_Chrome
Esquema do Cenario: CN02 - logoff_MenuSuperiorEsquerdo
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Clicar no menu principal
	E Clicar no menu Sair
	Entao O usuário é desconectado do sistema retornando para tela de login <mensagem>
Exemplos: 
	| CasoTeste                          | usuario     | mensagem          |
	| logoffSolicitante_QdoUsuarioLogado | solicitante | ENTRAR NO SISTEMA |
	| logoffAprovador_QdoUsuarioLogado   | aprovador   | ENTRAR NO SISTEMA |
	| logoffSecretaria_QdoUsuarioLogado  | secretaria  | ENTRAR NO SISTEMA |
	| logoffFinanceiro_QdoUsuarioLogado  | financeiro  | ENTRAR NO SISTEMA |