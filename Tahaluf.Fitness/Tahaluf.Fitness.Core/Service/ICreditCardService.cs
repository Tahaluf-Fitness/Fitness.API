using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface ICreditCardService
    {
        public List<CreditCard> GetCreditCard();
        public bool CreateCreditCard(CreditCard creditCard);
        public bool UpdateCreditCard(CreditCard creditCard);
        public bool DeleteCreditCard(int id);
    }
}
