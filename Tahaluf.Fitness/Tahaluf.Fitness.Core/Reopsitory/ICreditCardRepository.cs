using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface ICreditCardRepository
    {
        public List<CreditCard> GetCreditCard();
        public bool CreateCreditCard(CreditCard creditCard);
        public bool UpdateCreditCard(CreditCard creditCard);
        public bool DeleteCreditCard(int id);
    }
}
