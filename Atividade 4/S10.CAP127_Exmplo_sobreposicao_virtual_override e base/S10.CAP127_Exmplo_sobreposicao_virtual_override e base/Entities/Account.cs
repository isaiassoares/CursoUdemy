using System;
using System.Collections.Generic;
using System.Text;

namespace S10.CAP127_Exmplo_sobreposicao_virtual_override_e_base.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(global::System.Int32 number, global::System.String holder, global::System.Double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
