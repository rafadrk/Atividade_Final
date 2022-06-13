using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionário_2
{
    class Funcionario
    {
        //define as variáveis
        public string Nome { get; set; }
        public double Salariobruto { get; set; }
        public double Imposto   { get; set; }

        //aqui ele redefine o valor dessas variáveis, para puxar as mesmas variáveis no código original (program)
        public Funcionario(string nome, double salariobruto, double imposto)
        {
            Nome = nome;
            Salariobruto = salariobruto;
            Imposto = imposto;
        }

        //faz o calculo do salario líquido (salario bruto - imposto)
        public double CalculoSalarioLiq()
        {
            return Salariobruto - Imposto;
        }

        //aqui ele calcula o percentual (aumento de salario) 
        public void AumentoSalario(double perct_aumento)
        {
            Salariobruto += (Salariobruto * perct_aumento / 100);
        }

        //o override serve para a impressão dos dados no programa principal, puxando os dados e deixando o código otimizado
        public override string ToString()
        {
            return "O funcionário:" + Nome.ToUpper()
                + "\n Que recebe o salário líquido de R$" + Salariobruto.ToString("F2")
                + "\n Descontando o imposto de R$" + Imposto.ToString("F2")
                + "\n Recebe o salário bruto líquido R$" + CalculoSalarioLiq().ToString("F2")
                + " de pagamento mensal";

        }
    }
}
