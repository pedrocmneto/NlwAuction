using NlwAuction.API.Entities;

namespace NlwAuction.API.Contracts
{
	public interface IOfferRepository
    {
        void Add(Offer offer);
    }
}
