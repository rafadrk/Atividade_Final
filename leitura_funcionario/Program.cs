using System;

namespace Dados_Funcionário_2
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            //Faz com que ao funcionário digitar o número de funcionarios, armazene o número
            Console.WriteLine("Digite o numero de funcionários que deseja calcular: ");
            int contar = int.Parse(Console.ReadLine());

            //puxa o vetor da classe Funcionário, definindo um valor de contagem (contar)
            Funcionario[] colaborador = new Funcionario[contar];

            //o for serve de um looping de repetição com os dados do colaborador, usando o valor de contagem como limíte.
            for (int i = 0; i < contar; i++)
            {
                //faz com que seja pulado um número apenas na numeração, para que não mude a ordem original do numero de contagem no vetor (0,1,2,3,...)
                Console.WriteLine("Entre com os dados do Colaborador" + (i + 1) + ": ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario Bruto: ");
                double salariobruto = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o imposto: ");
                double imposto = double.Parse(Console.ReadLine());

                //define o vetor de contagem (i) para a classe e também define as variáveis, para que o armazenamento dessas variáveis sejam feitas a cada funcionário
                colaborador[i] = new Funcionario(nome, salariobruto, imposto);
            }

            //for utilizado para a impressão de dados do funcionário, com o armazenamento no vetor de contagem
            for (int i = 0; i < contar; i++)
            {
                Console.WriteLine("-----------------------------------------------");
                // faz com que seja pulado um número apenas na numeração, para que não mude a ordem original do numero de contagem no vetor(0,1,2,3,...)
                Console.WriteLine("---------Dados do Funcionário" + (i + 1) + "---------");
                Console.WriteLine(colaborador[i]);
            }

            for (int i = 0; i < contar; i++)
            {
                Console.WriteLine(); Console.WriteLine();
                //faz com que seja pulado um número apenas na numeração, para que não mude a ordem original do numero de contagem no vetor(0,1,2,3,...)
                Console.WriteLine("Quanto você quer de aumento, Colaborador" +(i+1) +"?");
                double percent_aumento = double.Parse(Console.ReadLine());
                //puxa a classe, com o vetor de contagem e puxa a função com vetor estabelecido na pergunta anterior (percent_aumento)
                colaborador[i].AumentoSalario(percent_aumento);

                //imprime o valor total final 
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("Esse é o seu aumento total = " + colaborador[i]);
            }



            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine();
        }
    }
}
