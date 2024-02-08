using Microsoft.AspNetCore.Mvc;
using NlwAuction.API.Communication.Requests;
using NlwAuction.API.Filters;
using NlwAuction.API.UseCases.Offers.CreateOffer;

namespace NlwAuction.API.Controllers
{
	[ServiceFilter(typeof(AuthenticationUserAttibute))]
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request, [FromServices] CreateOfferUseCase useCase)
        {
            var id = useCase.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}
