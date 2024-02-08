using Bogus;
using FluentAssertions;
using Moq;
using NlwAuction.API.Contracts;
using NlwAuction.API.Entities;
using NlwAuction.API.Enums;
using NlwAuction.API.UseCases.Auctions.GetCurrent;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent
{
	public class GetCurrentAuctionUseCaseTest
	{
		[Fact]
		public void Success()
		{
			// Arrange (1º A) 
			// Inicialização
			var entity = new Faker<Auction>() //Moq
				.RuleFor(auction => auction.Id, f => f.Random.Number(1, 700))
				.RuleFor(auction => auction.Name, f => f.Lorem.Word())
				.RuleFor(auction => auction.Starts, f => f.Date.Past())
				.RuleFor(auction => auction.Ends, f => f.Date.Future())
				.RuleFor(auction => auction.Items, (f, auction) => new List<Item>
				{
				new Item
				{
					Id = f.Random.Number(1, 700),
					Name = f.Commerce.ProductName(),
					Brand = f.Commerce.Department(),
					BasePrice = f.Random.Decimal(50, 1000),
					Condition = f.PickRandom<Condition>(),
					AuctionId = auction.Id
				}
				}).Generate();

			var mock = new Mock<IAuctionRepository>();
			mock.Setup(i => i.GetCurrent()).Returns(entity);

			var useCase = new GetCurrentAuctionUseCase(mock.Object);

			// Act (2º A)
			// Execução (Ação)
			var auction = useCase.Execute();

			// Assert (3º A)
			// Testes

			// Assert.NotNull(auction);
			auction.Should().NotBeNull(); //FluentAssertions

			/*
               Não se faz if, swits, etc... em teste de unidade.
               Para realizar os testes devemos implementar interfaces. 
            */
		}
	}
}