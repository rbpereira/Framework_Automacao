Funcionalidade: CN03 - Esqueci minha senha
	Funcionalidade que valida a pagina de esqueci minha senha.

@Browser_Chrome
Esquema do Cenario: CN03 - Esqueci minha senha
	Dado Que o sistema esteja aberto na pagina de login
	Quando Clicar no link Esqueci minha senha
	E No campo Username/email inserir <username>
	E Clicar no botão submit
	Entao É apresentanda a mensagem <mensagem>
@Source:..\..\MassaDeDados\MassaDeDados.xlsx:EsqueciMinhaSenha
Exemplos: 
	| CasoTeste | username | mensagem |