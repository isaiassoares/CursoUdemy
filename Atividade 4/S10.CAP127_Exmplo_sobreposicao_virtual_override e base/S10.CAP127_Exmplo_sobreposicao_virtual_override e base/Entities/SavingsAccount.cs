using System;
using System.Collections.Generic;
using System.Text;

namespace S10.CAP127_Exmplo_sobreposicao_virtual_override_e_base.Entities
{
    class SavingsAccount: Account
    {
        public double Interestrate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, doble balance, double interestRate)
            :base(number,holder,balance)
        {
            Interestrate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * Interestrate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
