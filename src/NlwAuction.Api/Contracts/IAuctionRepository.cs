using NlwAuction.API.Entities;

namespace NlwAuction.API.Contracts
{
	public interface IAuctionRepository
	{
		Auction? GetCurrent();
	}
}
