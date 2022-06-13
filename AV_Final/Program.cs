
using System;

namespace dados_retangulo
{
    class Programa
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Atividade  -  Dados Retângulo");
            Console.WriteLine();

            //define uma variavel perimetro para calcular o valor do perimetro do retângulo
            double perimetro;

            //pergunta para o usuario quantos retângulos deseja fazer o calculo
            Console.WriteLine("Digite quantos retângulos quieres calcurar: ");
            int contar = int.Parse(Console.ReadLine());

            //define a classe retangulho e aplica um vetor de contagem (contar)
            Retangulo[] retangulo = new Retangulo[contar];

            //for serve como um looping de repetição e armazena o vetor de contagem
            //o for serve para contar até o numero escolhido de retângulos
            for (int i = 0; i < contar; i++)
            {
                //Durante o laço de repetição for (com o número escolhido pelo vetor contar), irá perguntar para o usuario os dados do retângulo
                Console.WriteLine("Digite os valores do retângulo " + (i + 1) + ": ");
                Console.WriteLine("Altura: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Largura: ");
                double largura = double.Parse(Console.ReadLine());

                //faz o usuario pressionar enter para que prossiga para a próxima etapa do código
                Console.WriteLine("Pressione ENTER para prosseguir.");
                Console.ReadLine();

                //aqui acontece a redefinição do retangulo, onde puxa como vetor o valor de i (numero de repetição) e outros valores: a altura e a largura. Dessa forma, puxando os
                //valores em relação ao número de repetição (0,1,2,...)
                retangulo[i] = new Retangulo(altura, largura);
            }

            //esse for é para a impressão dos calculos desse retângulo desse retângulo
            for (int i = 0; i < contar; i++)
            {
                Console.WriteLine("OS VALORES DO RETANGULO: " + (i + 1) + ": ");
                Console.WriteLine(retangulo[i]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}
