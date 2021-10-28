using SList.Infrastructure.Repositories;
using SList.Test.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SList.Test.Infrastructure
{
    public class UsersTests
    {
        private readonly Seeding _seeder;
        private readonly UserRepository _userRepository;

        public UsersTests()
        {
            _seeder = new Seeding();
            _userRepository = new UserRepository(_seeder.GetFactory());

        }
        [Fact]
        public void UserGetTest()
        {
            using var ctx = _seeder.BuildContext();
            if (!ctx.Users.Any())
            {
                _seeder.Seed();
            }
            Assert.NotEmpty(ctx.Users);
            var firstUser = ctx.Users.First();

            var foundUser = _userRepository.Get(firstUser.Username, firstUser.Password);

            Assert.Equal(firstUser, foundUser);
        }

    }
}
