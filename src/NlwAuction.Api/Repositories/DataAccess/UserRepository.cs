﻿using NlwAuction.API.Contracts;
using NlwAuction.API.Entities;

namespace NlwAuction.API.Repositories.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;

        public UserRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

        public bool ExistUserWihtEmail(string email)
        {
            return _dbContext.Users.Any(user => user.Email.Equals(email));
        }

        public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
    }
}
