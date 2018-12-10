Funcionalidade: CN11 - Validar Reembolso
Esta funcionalidade tem o objetivo de permitir que os colaboradores da Prodesp que tenha credenciais de financeiro valide as solicitações de reembolso.

@Browser_Chrome
Cenario: CN11 - validarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Validar
	Dado Que o usuário Financeiro esteja logado no sistema
	E Navegar até a pagina de Validar reembolso
	Quando selecionar uma solicitação 
	E Clicar no botão validar
	E Validar a mensagem Validar reembolso?
	E Confirmar a validação
	E Validar a mensagem Reembolso validado com sucesso!
	E Fechar o modal
	E Clicar no botão Voltar da pagina Reembolso
	Entao Verificar se na tabela Validar não consta a solicitação

@Browser_Chrome
Cenario: CN11 - validarReembolso_QdoStatusAguardandoVerificacaoFinanceiro_Devolver
	Dado Que o usuário Financeiro esteja logado no sistema
	E Navegar até a pagina de Validar reembolso
	Quando selecionar uma solicitação 
	E Clicar no botão Devolver
	E Validar a mensagem Justificativa
	E Inserir Justificativa Por favor, verifique a solicitação.
	E Confirmar Devolução
	E Validar a mensagem Reembolso devolvido com sucesso!
	E Fechar o modal
	E Clicar no botão Voltar da pagina Reembolso
	Então Verificar se na tabela Validar não consta a solicitação