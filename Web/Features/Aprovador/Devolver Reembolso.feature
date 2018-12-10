# language: pt
Funcionalidade: CN07 - Devolver Reembolso
	Esta funcionalidade tem o objetivo de permitir que o aprovador devolva uma solicitação de reembolso.

@Browser_Chrome
Cenario: CN07 - devolver_QdoIncluiOMotivo
	Dado Que o usuário Aprovador esteja logado no sistema
	E Navegar até a pagina de aprovar reembolso
	Quando Selecionar a quantidade de reembolsos 1
	E Na tabela clicar no botão Devolver
	E Validar a mensagem Justificativa
	E Inserir Justificativa Por favor, verifique a solicitação.
	E Clicar no botão Devolver
	E Validar a mensagem Reembolso devolvido com sucesso!
	E Fechar o modal
	Entao Verificar se a solicitação consta na lista para aprovar