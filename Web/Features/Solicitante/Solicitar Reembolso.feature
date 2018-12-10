# language: pt
Funcionalidade: CN04 - Solicitar Reembolso
	Esta funcionalidade tem o objetivo de permitir que os colaboradores da Prodesp abra uma solicitação de reembolso.
	A solicitação pode ser aberta pelo próprio colaborador ou no caso de gestor pode ser aberta pela sua secretaria.

@Browser_Chrome
Esquema do Cenario: CN04 - Solicitar Reembolso
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesas>, origem <origem> e destino <destino> e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Enviar para <enviarpara>
	Entao É apresentanda a mensagem <mensageminterrogativa> 
	E Confirmar o envio
	E Validar informações do envio ou rascunho <descricao>

@Source:..\..\MassaDeDados\MassaDeDados.xlsx:SolicitarReembolso
Exemplos: 
| CasoTeste | usuario | motivo | qual | descricao | temRecurso | recurso | codDescricao | despesas | origem | destino | enviarpara | mensageminterrogativa | mensagemconfirmacao | CaminhoComprovante |

@Browser_Chrome
Esquema do Cenario: CN04 - solicitarReembolso_QdoPossuiDiversasDespesasValidarSomaDeValores
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_1>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_2>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	Entao Validar o valor total de despesas
Exemplos: 
	| usuario     | motivo | qual            | descricao               | temRecurso | recurso    | codDescricao | despesa_1 | despesa_2 |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Sim        | Poupatempo | B0000957     | MetroTrem | Onibus    | 

@Browser_Chrome	
Esquema do Cenario: CN04 - solicitarReembolso_QdoDeletarUmaDespesaValidarSubtracaoDeValores
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_1>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_2>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	Entao Validar o valor total de despesas
	E Excluir uma Despesa
	E Validar o valor total de despesas
Exemplos: 
	| usuario     | motivo | qual            | descricao               | temRecurso | recurso    | codDescricao | despesa_1 | despesa_2 |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Sim        | Poupatempo | B0000957     | MetroTrem | Onibus    | 

@Browser_Chrome
Esquema do Cenario: CN04 - solicitarReembolso_QdoClicarNoBotaoVoltarValidarMensagemDeCancelamento
Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Clicar no botão Voltar
	Entao É apresentanda a mensagem <mensagem>
	E Clicar no botão OK
Exemplos: 
	| usuario     | motivo | qual            | descricao               | mensagem                                |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Você perderá todos os dados não salvos. |

@Browser_Chrome
Esquema do Cenario: CN04 - Solicitar reembolso e validar lançamentos duplicados
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	Entao É apresentanda a mensagem <mensagem>
	E Clicar no botão OK
Exemplos: 
	| usuario     | motivo | qual            | descricao               | temRecurso | recurso    | codDescricao | despesa   | mensagem          |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Sim        | Poupatempo | B0000957     | MetroTrem | Já existe despesa |

@Browser_Chrome
Esquema do Cenario: CN04 - solicitarReembolso_QdoPossuiTodasDespesasEnviarParaAprovacao
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_1>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_2>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_3>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_4>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_5>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_6>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Salvar despesas
	E Enviar para <enviarpara>
	Entao É apresentanda a mensagem <mensageminterrogativa> 
	E Confirmar o envio
	E Validar informações do envio ou rascunho <descricao>
Exemplos: 
	| usuario     | motivo | qual            | descricao               | temRecurso | recurso    | codDescricao | despesa_1      | despesa_2 | despesa_3 | despesa_4 | despesa_5 | despesa_6      | CaminhoComprovante | enviarpara | mensageminterrogativa            |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Sim        | Poupatempo | B0000957     | Estacionamento | MetroTrem | Onibus    | Pedagio   | Taxi      | VeiculoProprio |                    | Aprovacao  | Enviar reembolso para aprovação? |

@Browser_Chrome
Esquema do Cenario: CN04 - SolicitarReembolso_QdoPossuiDespesaVeiculo_ValidarKmAcimaDoPermitido
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesas>, origem <origem> e destino <destino> e comprovante <CaminhoComprovante>
	Entao É apresentanda a mensagem <mensagem>
Exemplos: 
	| usuario     | motivo | qual            | descricao               | temRecurso | recurso    | codDescricao | despesas       | origem         | destino                                            | CaminhoComprovante               | mensagem                                                     |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Sim        | Poupatempo | B0000957     | VeiculoProprio | Prodesp - Sede | Rua São José do Rio Preto, Araraquara - SP, Brasil | Enviar reembolso para aprovação? | A distancia total percorrida não pode ser superior a 150 km. |

@Browser_Chrome
Esquema do Cenario: CN04 - solicitarReembolso_QdoPossuiDespesaEstacionamento_ValidarCnpjProdesp
	Dado Que o usuário <usuario> esteja logado no sistema
	Quando Iniciar uma nova solicitação
	E Informar o motivo <motivo>, qual <qual> e descrição <descricao>
	E Informar se está associado a um recurso <temRecurso>, recurso <recurso> e Cod/Descrição <codDescricao>
	E Clicar no botão adicionar despesas
	E Inserir despesas <despesa_1>, origem <origem> e destino <destino>  e comprovante <CaminhoComprovante>
	E Informar o <CNPJ> do estabelecimento
	Entao Validar a mensagem <mensagem>
Exemplos: 
	| usuario     | motivo | qual            | descricao               | temRecurso | recurso    | codDescricao | despesa_1      | CaminhoComprovante | CNPJ               | mensagem                                                                     |
	| solicitante | Outro  | Reunião externa | Alinhamento de projetos | Sim        | Poupatempo | B0000957     | Estacionamento |                    | 62.577.929/0001-35 | O CNPJ da Prodesp não pode ser informado no campo "CNPJ do estabelecimento". |



##Esquema do Cenario: Solicitar reembolso pelo perfil da secretária
##	Dado Que o solicitante esteja logado no sistema
##	Quando Clicar no botão Solicitar reembolso
##	E Selecionar o motivo
##	E Preencher o campo Descrição 'Teste'
##	E Responder SIM para a pergunta 'Este reembolso está associado a algum recurso'
##	E Selecionar o tipo de recurso e inserir o código da descrição 'cod'
##	E Adicionar em despesa a opção metro/trem
##	E Preencher os campos Data de despesa '28/08/2018', estação de origem 'Butanta', estação de destino 'Luz' 
##	E Marcar o checkbox Ida/Volta
##	E Clicar no botão Salvar
##	E Enviar para Aprovação
##	Entao A solicitação é enviada para o Aprovador
##
##@Source:..\..\MassaDeDados\MassaDeDados.xlsx:SolicitarReembolso
##Exemplos: 
##		  | motivo | descricao | despesas |	mensageminterrogativa |	mensagemconfirmacao |
##
#
#