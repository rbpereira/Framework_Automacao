# language: pt
Funcionalidade: CN08 - Aprovar Reembolso
	Esta funcionalidade tem o objetivo de permitir que o aprovador aprove uma solicitação de reembolso.

@Browser_Chrome
Cenario: CN08 - aprovar_QdoOk
	Dado Que o usuário Aprovador esteja logado no sistema
	E Navegar até a pagina de aprovar reembolso
	Quando Selecionar a quantidade de reembolsos 1
	E Na tabela clicar no botão Aprovar
	E Validar a mensagem Aprovar reembolso?
	E Clicar no botão Aprovar
	E Validar a mensagem Reembolso aprovado com sucesso!
	E Fechar o modal
	Entao Verificar se a solicitação consta na lista para aprovar

@Browser_Chrome
Cenario: CN08 - aprovarMaisDeUmaSolicitacao_QdoOk
	Dado Que o usuário Aprovador esteja logado no sistema
	E Navegar até a pagina de aprovar reembolso
	Quando Selecionar a quantidade de reembolsos 2
	E clicar no botão Aprovar Selecionados
	E Validar a mensagem Aprovar reembolsos selecionados?
	E Clicar no botão Aprovar
	E Validar a mensagem Reembolso aprovado com sucesso!
	E Fechar o modal
	Entao Verificar se a solicitação consta na lista para aprovar

@Browser_Chrome
Cenario: CN08 - aprovarSolicitacao_QdoNaoTemSolicitacaoSelecionada_validarMensagemDeObrigatoriedade
	Dado Que o usuário Aprovador esteja logado no sistema
	E Navegar até a pagina de aprovar reembolso
	Quando clicar no botão Aprovar Selecionados
	Entao Validar a mensagem É necessário marcar pelo menos um reembolso para aprovar.