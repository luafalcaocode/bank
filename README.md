# bank

Projeto contendo uma Web API construída com ASP .NET Core 3.1. 

## Documentação da API:

https://localhost:44332/swagger/index.html

## Pré-requisitos:

Antes de executar o projeto certifique-se de ter as configurações abaixo instaladas no seu ambiente.

+ .NET Core SDK 3.1
+ Visual Studio 2019 ou o Visual Studio Code
+ Privilégios de administrador no Sistema Operacional


## Rodando o projeto:

Siga os passos abaixo para rodar o projeto.

1. Clone este repositório utilizando o GIT para um diretório na sua máquina
2. Abra a solução no Visual Studio
3. Pressione F5 para rodar o projeto
4. Você deverá ver a página do Swagger com os endpoints disponíveis

## Configurando as migrations:

Para sincronizar o modelo de dados e mapear as classes OO para as tabelas em um banco de dados siga os passos abaixo:

1. Abra os arquivos appsettings.json e appsettings.Development.json e altere as configurações de string de conexão no objeto SqlServerConnection para refletir o seu próprio servidor de banco de dados
2. Abra o gerenciador de pacotes do Nuget e digite o comando Update-Database 
3. Ao final as tabelas deverão ser criadas no seu banco de dados 

Obs.: em caso de problemas para rodar o projeto verifique se seu anti-virus está bloqueando a execução do projeto
