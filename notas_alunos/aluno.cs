using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aluno_notas
{
    internal class Aluno
    {
        //definição de variaveis 
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        //aqui ele redefine o valor dessas variáveis, para puxar as mesmas variáveis no código original (program)
        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        //faz a soma das notas do aluno
        public double TotalNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        //o override serve para a impressão dos dados no programa principal, puxando os dados e deixando o código otimizado
        public override string ToString()
        {
            return "Nome------------ " + Nome
                       + "\n Nota1: " + Nota1
                       + "\n Nota2: " + Nota2
                       + "\n Nota3: " + Nota3
                       + "\n \n =============NOTA FINAL=============" 
                       +"\n NOTA TOTAL: " + TotalNota();
        }
    }
}
