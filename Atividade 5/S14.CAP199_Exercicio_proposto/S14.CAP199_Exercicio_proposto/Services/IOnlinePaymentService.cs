using System;
using System.Collections.Generic;
using System.Text;

namespace S14.CAP199_Exercicio_proposto.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
