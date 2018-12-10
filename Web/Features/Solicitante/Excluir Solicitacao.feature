# language: pt
Funcionalidade: CN10 - Excluir Solicitacao
	Funcionalidade tem o objetivo de permitir que os colaboradores da Prodesp exclua solicitações criadas.

@Browser_Chrome
Esquema do Cenario: CN10 - excluirSolicitacao_QdoEmRascunho
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Visualizar solicitação com status <status>
	E Clicar no botão Excluir Reembolso
	Entao É apresentanda a mensagem <mensageminterrogativa> 
	E Clicar no botão Excluir
	E Validar mensagem <mensagemconfirmacao> de confirmação
	E Clicar em OK
	E Verificar se o reembolso foi deletado da tabela de meus reembolsos

Exemplos: 
	| usuario     | mensageminterrogativa               | mensagemconfirmacao             | status   |
	| solicitante | Excluir a solicitação de reembolso? | Reembolso excluído com sucesso! | rascunho |