using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardService creditCardService;

        public CreditCardController(ICreditCardService creditCardService)
        {
            this.creditCardService = creditCardService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        public List<CreditCard> GetCreditCard()
        {
            return creditCardService.GetCreditCard();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCreditCard(CreditCard creditCard)
        {
            return creditCardService.CreateCreditCard(creditCard);
        }


        [HttpPut]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCreditCard(CreditCard creditCard)
        {
            return creditCardService.UpdateCreditCard(creditCard);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        public bool DeleteCreditCard(int id)
        {
            return creditCardService.DeleteCreditCard(id);
        }
    }
}
