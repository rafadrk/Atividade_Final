using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quarto_de_aluguel
{
    class Quarto
    {
        //define as variaveis
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Datanascimento { get; set; }

        //aqui ele redefine o valor dessas variáveis, para puxar as mesmas variáveis no código original (program)
        public Quarto(string nome, string cpf, string telefone, string email, string sexo, string datanascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
            Datanascimento = datanascimento;
        }

        //o override serve para a impressão dos dados no programa principal, puxando os dados e deixando o código otimizado
        public override string ToString()
        {
            return "Aluno: " + Nome.ToUpper()
                + "\n Data de Nascimento: " + Datanascimento
                + "\n CPF: " + Cpf
                + "\n Telefone: " + Telefone
                + "\n E-Mail: " + Email
                + "\n Sexo: " + Sexo;
        }

    }

    //nova classe para puxar os dados de valor
    //define as variaveis de valor e meses
    class dadosquarto
    {

        public double Valor { get; set; }
        public double Meses { get; set; }

        //aqui ele redefine o valor dessas variáveis, para puxar as mesmas variáveis no código original (program)
        public dadosquarto(double valor, double meses)
        {
            Valor = valor;
            Meses = meses;
        }

        //realiza a conta de multiplicação do valor pelos meses que o cliente passou no hotel
        public double Alugueltotal()
        {
            return Valor * Meses;
        }

        //o override serve para a impressão dos dados no programa principal, puxando os dados e deixando o código otimizado
        public override string ToString()
        {
            return "Valor do Quarto Escolhido: " + Valor
                    + "\n Periodo (Meses): " + Meses
                    + "\n VALOR TOTAL DO QUARTO -----------------------------------------------------" + Alugueltotal();
        }

    }
}