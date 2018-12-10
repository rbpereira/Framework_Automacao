# language: pt
Funcionalidade: CN09 - Reprovar Reembolso
	Esta funcionalidade tem o objetivo de permitir que o aprovador reprove uma solicitação de reembolso.

@Browser_Chrome
Cenario: CN09 - reprovar_QdoIncluiOMotivo
	Dado Que o usuário Aprovador esteja logado no sistema
	E Navegar até a pagina de aprovar reembolso
	Quando Selecionar a quantidade de reembolsos 1
	E Na tabela clicar no botão Reprovar
	E Validar a mensagem Justificativa
	E Inserir Justificativa Solicitação reprovada por conter dados incorretos.
	E Clicar no botão Reprovar
	E Validar a mensagem Reembolso reprovado com sucesso!
	E Fechar o modal
	Entao Verificar se a solicitação consta na lista para aprovar