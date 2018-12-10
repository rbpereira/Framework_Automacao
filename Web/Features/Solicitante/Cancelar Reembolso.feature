# language: pt
Funcionalidade: CN06 - Cancelar Reembolso
	Funcionalidade tem o objetivo de permitir que os colaboradores da prodesp cancele um reembolso
@Browser_Chrome
Cenario: CN06 - cancelarReembolso_QdoDevolvidaPeloGestor
	Dado Que o usuário solicitante esteja logado no sistema
	Quando Visualizar solicitação com status Devolvido
	E Validar a mensagem O seu reembolso foi devolvido pelo
	E Fechar modal de justificativa
	E Clicar no botão Cancelar Reembolso
	Entao Validar a mensagem Cancelar a solicitação de reembolso?
	E Confirmar o cancelamento do reembolso
	E Validar a mensagem Reembolso cancelado com sucesso!
	E Clicar no botao OK