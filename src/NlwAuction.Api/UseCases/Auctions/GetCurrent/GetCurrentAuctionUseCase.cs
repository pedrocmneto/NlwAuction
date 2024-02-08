using Microsoft.EntityFrameworkCore;
using NlwAuction.API.Contracts;
using NlwAuction.API.Entities;
using NlwAuction.API.Repositories;

namespace NlwAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

        public Auction? Execute() => _repository.GetCurrent();
    }
}
