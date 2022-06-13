using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_retangulo
{
    internal class Retangulo
    {
        //define as variaveis de largura e altura
        public double Largura { get; set; }
        public double Altura { get; set; }

        //aqui ele redefine o valor dessas variáveis, para puxar as mesmas variáveis no código original (program)
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        //area define o calculo da area do retângulo
        public double Area()
        {
            return Altura * Largura;
        }

        //perimetro define o calculo do perimetro do retângulo
        public double Perimetro()
        {
            return 2 * (Largura + Altura);

        }

        //diagonal define o calculo da diagonal do retângulo
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        //o override serve para a impressão dos dados no programa principal, puxando os dados e deixando o código otimizado
        public override string ToString()
        {
            return "A área do retângulo é: " + Area()
                    + "\nO perímetro do retângulo é: " + Perimetro()
                    + "\nA diagonal do retânfulo é: " + Diagonal();
        }



    }
}