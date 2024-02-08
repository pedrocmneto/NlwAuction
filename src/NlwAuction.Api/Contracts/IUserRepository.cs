using NlwAuction.API.Entities;

namespace NlwAuction.API.Contracts
{
	public interface IUserRepository
	{
		bool ExistUserWihtEmail(string email);
		User GetUserByEmail(string email);
	}
}
