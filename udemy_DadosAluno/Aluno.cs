using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemy_DadosAluno
{
    internal class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool aprovacao()
        {
            if ((nota1 + nota2 + nota3) < 60)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double pontosFaltantes()
        {
            return 60 - (nota1 + nota2 + nota3);
        }
    }
}
