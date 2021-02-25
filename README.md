### App Revisão .NET Core - Array de Alunos

Criada por mim, @nicoloide01, esta é uma aplicação criada utilizando .NET Core e C# visando a prática das linguagens em questão. A proposta é criar um sistema de inserção de alunos de uma "turma" em console, onde o usuário possa realizar as seguintes operações:

* Adicionar alunos
* Consultar alunos
* Calcular a média geral dos alunos
* Sair da aplicação

As operações são auto-explicativas e, no momento da criação deste README, o limite de alunos a serem adicionados é 5, portanto o usuário pode adicionar, consultar e calcular a média de até 5 alunos.

Para iniciar a aplicação, no momento, é necessária a utilização de um terminal de console(o padrão do Windows, Bash ou outros), os arquivos deste repositório e a SDK do .NET Core, disponibilizada oficialmente e de graça pela Microsoft. Navegue até a pasta da aplicação baixada e utilize o comando *dotnet run* e a aplicação em console se dará início.



Para o desenvolvimento do app, escolhi organizar em uma classe **Aluno** os atributos dos alunos a serem inseridos e em uma struct **Conceito**, as definições de conceito para as médias. A escolha da struct para os conceitos foi puramente didática, visto que não acho necessário a alocação de memória de uma struct para um fim tão simples *neste caso*, a utilização de uma string seria muito mais viável.



Acredito que com a leitura dos comentários que coloquei na codificação do programa, uma pessoa consiga entender o que cada função faz e por quê escolhi aquela forma de resolução de problema, assim ajudando tanto os usuários do GitHub a entender minha aplicação(por mais simples que seja) e a mim mesmo, localizando informações a serem alteradas ou relembradas para algum fim no futuro. Segue uma lista de funcionalidades(maioria acredito que exceções) que acredito que colaborariam com o app e que ainda não coloquei.



### TODO LIST:

1. Não deixar o usuário calcular a média sem entrar nenhum aluno(atualmente resulta em UnhandledException)
2. Adicionar função para que o usuário consiga limitar ele mesmo a quantidade de alunos na turma ou retirar o limite(?) de alunos