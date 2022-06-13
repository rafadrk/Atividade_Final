using System;

namespace aluno_notas
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto  - Notas de Aluno ");
            Console.WriteLine();

            //Pergunta para o usuário a quantidade de alunos que deseja selecionar 
            Console.WriteLine("Quantos alunos você deseja?");
            int permiso = int.Parse(Console.ReadLine());

            //define um vetor para puxar o numero de alunos que o usuário escolheu para a classe
            Aluno[] aluno = new Aluno[permiso];

            //cria um looping de repetição que irá perguntar os dados do aluno (notas) 
            for (int i = 0; i < permiso; i++)
            {
                Console.WriteLine("--------------- DADOS DO ALUNO ----------------");
                Console.WriteLine("Nome de Aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite as três notas do aluno:");
                double nota1 = double.Parse(Console.ReadLine());
                double nota2 = double.Parse(Console.ReadLine());
                double nota3 = double.Parse(Console.ReadLine());

                //este if será para que a primeira nota não passe de 30 pontos
                if (nota1 > 30)
                {
                    Console.WriteLine("Esta nota é invalida!");
                    Console.WriteLine();
                    return;
                }

                //este else if será para o usuário não passar de 35 pontos durantes as notas 2 e 3
                else if (nota2 > 35 && nota3 > 35)
                {
                    Console.WriteLine("Esta nota é invalida!");
                    Console.WriteLine();
                    return;
                }

                //puxa um vetor de contagem [i] para a classe aluno (nome, nota1, nota2, nota3) 
                aluno[i] = new Aluno(nome, nota1, nota2, nota3);

            }

            //cria um laço de repetição em for para a impressão dos dados previamente digitados 
            for (int i = 0; i < permiso; i++)
            {
                 double totalnota = aluno[i].TotalNota();

                //pega o vetor de contagem (i) e soma + 1, nao alterando o vetor de contagem para o final do código
                Console.WriteLine("ALUNO " + (i + 1) + " ESSA É SUA NOTA FINAL ===============");
                Console.WriteLine(aluno[i]);

                //esse if define se o aluno será aprovado ou não
                //se sua nota for maior ou igual a 60 ele será aprovado
                if (totalnota >= 60)
                {
                    Console.WriteLine("Você foi aprovado");
                    Console.WriteLine();
                }
                //se não ele será reprovado e mostrará o quanto de pontos que faltaram para ele passar
                else
                {
                    Console.WriteLine("Você foi reprovado");
                    Console.WriteLine("Faltaram " + (60 - totalnota) + " pontos...");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}