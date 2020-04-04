using System;
using System.Globalization;


namespace S4.CAP45_Exercicios_propostos2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = SalarioBruto * (porcentagem / 100.00);
            SalarioBruto = SalarioBruto + porcentagem;
        }

        public override string ToString()
        {
            return Nome
            + ", $ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
