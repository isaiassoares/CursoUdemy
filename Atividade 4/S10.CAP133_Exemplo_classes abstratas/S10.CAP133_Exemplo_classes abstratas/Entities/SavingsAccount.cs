﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S10.CAP133_Exemplo_classes_abstratas.Entities
{
    class SavingsAccount : Account
    {
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
