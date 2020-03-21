using System;

namespace S3_Exemplo_restricoes_e_convencoes_p_nomes
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double _saldo;
        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public double GetSalso()
        {
            return _saldo;
        }
    }
}
