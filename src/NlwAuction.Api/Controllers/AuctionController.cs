using Microsoft.AspNetCore.Mvc;
using NlwAuction.API.Entities;
using NlwAuction.API.UseCases.Auctions.GetCurrent;

namespace NlwAuction.API.Controllers
{
	public class AuctionController : RocketseatAuctionBaseController
	{
	    [HttpGet]
	    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
	    [ProducesResponseType(StatusCodes.Status204NoContent)]
	    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
	    {
	        var result = useCase.Execute();
	        if (result is null)
			{
				return NoContent();
			}

	        return Ok(result);
	    }
	}
}
