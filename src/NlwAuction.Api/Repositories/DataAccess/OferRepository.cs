using NlwAuction.API.Contracts;
using NlwAuction.API.Entities;

namespace NlwAuction.API.Repositories.DataAccess
{
    public class OferRepository : IOfferRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;

        public OferRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

        public void Add(Offer offer)
        {
            _dbContext.Offers.Add(offer);
            _dbContext.SaveChanges();
        }
    }
}
