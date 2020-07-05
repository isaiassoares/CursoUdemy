using System;

namespace S11.CAP143_Excecoes_personalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
