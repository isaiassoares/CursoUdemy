using System;
using System.Collections.Generic;
using System.Text;

namespace S11.CAP146_Exercicios_propostos.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
