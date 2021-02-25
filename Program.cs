//Programa feito em conjunto do curso de introdução ao .NET Core da Digital Innovation One, 
//uma simples aplicação em console para aprender os comandos da CLI e praticar C# como um todo

using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];//cria o array da struct Aluno
            int indiceAluno = 0;//indice para controlar a posição a ser manuseada
            string opcaoUsuario = obterOpcaoUsuario();
            
            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1"://iniciar aluno
                        if(indiceAluno < alunos.Length){//nesse programa existe limite para a array de alunos, pode-se implementar opção pra alterar esse valor
                            Console.Write("Informe o nome do alune: ");
                            Aluno aluno = new Aluno();//instancia um novo aluno da struct Aluno
                            aluno.Nome = Console.ReadLine();//anexa o campo Nome da struct Aluno da variavel aluno, descrito pelo usuario
                            
                            Console.Write("\nInforme a nota do alune: ");
                            if(decimal.TryParse(Console.ReadLine(), out decimal nota)){//também pode usar Convert.ToDecimal
                                aluno.Nota = nota;
                            }else{
                                throw new ArgumentException("Valor da nota deve ser decimal");
                            }

                            alunos[indiceAluno] = aluno;//insere o aluno criado acima no indiceAluno da array alunos
                            indiceAluno++;
                        }else{
                            Console.WriteLine("Maximo de alunos excedido");
                        }
                        break;
                    case "2"://listar
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){//método string pra checar se é NULL
                                Console.WriteLine($"ALUNO: {a.Nome} | NOTA: {a.Nota}");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "3"://media, nota para o erro de dividir por 0 caso inicie com 3 sem 2 alunos no minimo
                        decimal notaTotal = 0;//precisa ser decimal pois Nota do struct Aluno é decimal
                        int nrAlunos = 0;
                        
                        for(int i = 0; i < alunos.Length; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){//para não mexer com os nulos, como no case 2
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }    
                        }
                        decimal mediaGeral = notaTotal / nrAlunos;

                        Conceito conceitoGeral;
                        if(mediaGeral < 3){
                            conceitoGeral = Conceito.E;
                        }else if(mediaGeral < 5){
                            conceitoGeral = Conceito.D;
                        }else if(mediaGeral < 6){
                            conceitoGeral = Conceito.C;
                        }else if(mediaGeral < 8){
                            conceitoGeral = Conceito.B;
                        }else{
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"MEDIA GERAL: {mediaGeral} | CONCEITO GERAL: {conceitoGeral}");    
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
        }
        private static string obterOpcaoUsuario(){//função de inicialização-menu
            Console.Write("Insira a opçao desejada: \n1- Inserir novo aluno\n2- Listar alunos\n");
            Console.Write("3- Calcular media geral\nX- Sair");
            Console.WriteLine("");
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine("");
            return opcaoUsuario;
        }
    }
}