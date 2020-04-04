using System;
using System.Collections.Generic;
using System.Text;

namespace S2.CAP45_Exercicios_propostos3
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
