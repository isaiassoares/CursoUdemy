using System;
using System.Collections.Generic;
using System.Text;

namespace S10.CAP127_Exmplo_sobreposicao_virtual_override_e_base.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
        LoanLimit: loanLimit;
        }
        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
