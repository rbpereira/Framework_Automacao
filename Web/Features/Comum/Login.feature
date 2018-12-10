Funcionalidade: CN01 - Login
	Funcionalidade que valida a pagina de Login.
#
@Browser_Chrome
#@Browser_Firefox
#@Browser_Edge
Esquema do Cenario: CN01 - Login
	Dado Que o sistema esteja aberto na pagina de login
	Quando Digitar login <login> e senha <senha>
	E Clicar no botão Entrar
	Entao É apresentanda a mensagem <mensagem>

@Source:..\..\MassaDeDados\MassaDeDados.xlsx:Login
Exemplos: 
	| CasoTeste  | login | senha | mensagem |