using System;


namespace quarto_de_aluguel
{
    class Programa
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Projeto  -  Aluguel Quarto");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("BEM VINDO AO SERVIÇO DE ALUGUEL DE APARTAMENTOS DO TOMATINHO");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine(); Console.WriteLine();

            //puxamos a primeira classe

            //pergunta o numero de quartos desejados ao usuário
            Console.WriteLine("Digite o número de quartos que deseja alugar:");
            int numeroquartos = int.Parse(Console.ReadLine());

            Quarto[] hospede = new Quarto[numeroquartos];

            //puxa o número escolhido anteriormente (numero de quartos)
            //e pergunta os dados desejados por cada quarto
            for (int i = 0; i < numeroquartos; i++)
            {
                Console.WriteLine("-------------HOSPEDE " + (i + 1) + "DIGITE SEUS DADOS------------");
                Console.WriteLine();
                Console.Write("Qual é o seu nome?");
                string nome = Console.ReadLine();
                Console.Write("Qual é o seu genero?");
                string sexo = Console.ReadLine();
                Console.Write("Qual é sua data de nascimento?");
                string datanascimento = Console.ReadLine();
                Console.Write("Qual é seu CPF?");
                string cpf = Console.ReadLine();
                Console.Write("Qual é o seu E-Mail?");
                string email = Console.ReadLine();
                Console.Write("Qual é o seu telefone?");
                string telefone = Console.ReadLine();
                Console.WriteLine();

                //puxa um vetor de contagem [i] para a classe hospede (nome, cpf, telefone, email, sexo, datanascimento)
                hospede[i] = new Quarto(nome, cpf, telefone, email, sexo, datanascimento);
            }

            //puxamos a segunda classe

            dadosquarto[] pagamento = new dadosquarto[numeroquartos];

            //puxa um laço de repetição for para que o hospede digite o valor desejado pelo quarto
            //junto com o vetor de contagem (i), que faz a mesma alteração no for anterior
            for (int i = 0; i < numeroquartos; i++)
            {
                Console.WriteLine("---------------HOSPEDE " + (i + 1) + ", DIGITE O VALOR DO QUARTO ------------------------");
                Console.WriteLine();
                Console.WriteLine("Qual é o valor do quarto por mês?");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos meses?");
                double meses = double.Parse(Console.ReadLine());


                //assim como no exercício anterior ele puxa o vetor de contagem (i) para a outra classe (pagamento), como valor e os meses.
                pagamento[i] = new dadosquarto(valor, meses);
            }

            //imprime o relatorio de dados do usuário, com o numero de quartos também...
            for (int i = 0; i < numeroquartos; i++)
            {
                Console.WriteLine("---------------RELATÓRIO DE DADOS DO HOSPEDE " + (i+1) + " ------------------------");
                Console.WriteLine();
                Console.WriteLine(hospede[i]);
                Console.WriteLine();
                Console.WriteLine(pagamento[i]);

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para prosseguir.");
                Console.ReadLine();
            }
        }
    }
}
