# language: pt
Funcionalidade: CN05 - Editar Reembolso
	Funcionalidade destinada a permitir que os colaboradores da Prodesp Edite as solicitações criadas.

@Browser_Chrome
Esquema do Cenario: CN05 - editarSolicitacao_QdoDevolvida
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Visualizar solicitação com status <statusAtual>
	E Validar a justificativa <justificativa>
	E Fechar modal de justificativa
	E Clicar no botão Enviar novamente
	E Validar a mensagem <mensagemInterrogativa>
	E Clicar no botão Enviar
	#Entao Validar a mensagem <mensagem>
	#E Clicar no botão OK
	Entao Validar se o status foi alterado para <NovoStatus>
Exemplos: 
	| usuario     | mensagem                       | mensagemInterrogativa            | justificativa                             | observacao | statusAtual        | NovoStatus                       |
	| solicitante | Reembolso enviado com sucesso! | Enviar reembolso para aprovação? | O seu reembolso foi devolvido pelo Gestor | Corrigido  | Devolvido (gestor) | Aguardando validação coordenador |

@Browser_Chrome
Esquema do Cenario: CN05 - editarSolicitacao_QdoRascunhoInserirDespesa
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Visualizar solicitação com status <statusAtual>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesas>, origem <origem> e destino <destino> e comprovante <CaminhoComprovante>	
	E Salvar despesa editada
	E Validar o valor total de despesas
	E Clicar no botão Enviar para aprovação
	Entao É apresentanda a mensagem Enviar reembolso para aprovação? 
	E Confirmar o envio
	E Validar se o status foi alterado para <NovoStatus>
Exemplos: 
	| usuario     | mensagem                       | despesas | statusAtual | NovoStatus                       |
	| solicitante | Reembolso enviado com sucesso! | Onibus   | rascunho    | Aguardando validação coordenador |

@Browser_Chrome
Esquema do Cenario: CN05 - editarSolicitacao_QdoRascunhoExluirDespesa
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Visualizar solicitação com status <statusAtual>
	E Validar o valor total de despesas
	E Excluir uma Despesa
	Entao Validar o valor total de despesas
Exemplos: 
	| usuario     | statusAtual |
	| solicitante | rascunho    |