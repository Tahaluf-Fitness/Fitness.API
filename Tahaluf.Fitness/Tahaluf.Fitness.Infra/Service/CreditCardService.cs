using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class CreditCardService: ICreditCardService
    {
        private readonly ICreditCardRepository creditCardRepository;

        public CreditCardService(ICreditCardRepository creditCardRepository)
        {
            this.creditCardRepository = creditCardRepository;
        }

        public List<CreditCard> GetCreditCard()
        {
            return creditCardRepository.GetCreditCard();
        }
        public bool CreateCreditCard(CreditCard creditCard)
        {
            return creditCardRepository.CreateCreditCard(creditCard);
        }
        public bool UpdateCreditCard(CreditCard creditCard)
        {
            return creditCardRepository.UpdateCreditCard(creditCard);
        }
        public bool DeleteCreditCard(int id)
        {
            return creditCardRepository.DeleteCreditCard(id);
        }
    }
}
