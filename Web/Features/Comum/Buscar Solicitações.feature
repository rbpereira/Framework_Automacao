#language: pt
Funcionalidade: Buscar Solicitações e Reembolsos
	Está funcionalidade tem o objetivo de permitir que os colaboradores da Prodesp pesquise solicitações criadas

#@Browser_Chrome
#Esquema do Cenario: Buscar Solicitações
#	Dado Que o usuário esteja logado no sistema e na pagina de busca de reembolso
#	Quando Informar data de solicitação <datasolicitacaoDe>, <datasolicitacaoAte>,  data do pagamento <dataPagamentoDe>, <dataPagamentoAte>, Número reembolso <nroReembolso> e status <status>
#	E Efetuar a busca
#	Entao São exibidos os reembolsos conforme o filtro ou mensagem <mensagem> de validação
#@Source:..\..\MassaDeDados\MassaDeDados.xlsx:BuscarSolicitacao
#Exemplos: 
#		  | datasolicitacaoDe  | datasolicitacaoAte  | dataPagamentoDe | dataPagamentoAte | nroReembolso| status| mensagem|
#
#
#@Browser_Chrome
#Esquema do Cenario: Busca_Qdo 
#	Dado Que o usuário esteja logado no sistema e na pagina Meus Reembolsos
#	Quando Inserir no campo de pesquisa <DadosPesquisa> 
#	E Efetuar a busca
#	Entao São exibidos os reembolsos conforme o filtro
#Exemplos: 
#		  | DadosPesquisa                           |
#		  | Rascunho                                |
#		  | Aguardando aprovação do gestor          |
#		  | Desenvolvido pelo Gestor                |
#		  | Aguardando validação do Financeiro      |
#		  | Liberado para recebimento na tesouraria |
#
#@Browser_Chrome
#Esquema do Cenario: Busca_QdoDesolvidoPeloGestorValidarMensagemDeDevolucao
#	Dado Que o usuário esteja logado no sistema e na pagina Meus Reembolsos
#	Quando Inserir no campo de pesquisa <DadosPesquisa> 
#	E Efetuar a busca
#	E clicar no icone para visualizar o reembolso
#	Entao É exibida a mensagem <mensagem>
#Exemplos: 
#		  | DadosPesquisa            | mensagem                                  |
#		  | Desenvolvido pelo Gestor | O seu reembolso foi devolvido pelo gestor |
#		  
