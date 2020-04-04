using System;
using System.Collections.Generic;
using System.Text;

namespace S6.CAP71_Exercicio_fixacao2
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
