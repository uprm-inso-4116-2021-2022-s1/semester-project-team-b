using Bogus;
using EFCore.BulkExtensions;
using SList.Infrastructure.Factories;
using SList.Infrastructure.Models;
using SList.Infrastructure.Repositories.Interfaces;
using SList.Test.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Test.Repositories
{
    public class SeedingRepository : ISeedingRepository
    {
        private SListContextFactory _contextFactory;
        private IUserRepository _userRepository;

        public SeedingRepository(SListContextFactory factory, IUserRepository userRepository) {
            _contextFactory = factory;
            _userRepository = userRepository;

        }

        public void Populate(int capcity)
        {
            var users = GenerateUsers(capcity);

            using var ctx = _contextFactory.CreateDbContext();
            ctx.BulkInsert(users);
            ctx.SaveChanges();

        }
        
        private List<User> GenerateUsers(int capcity) => 
            new Faker<User>()
                .RuleFor(u => u.FirstName, p => p.Name.FirstName())
                .RuleFor(u => u.LastName, p => p.Name.LastName())
                .RuleFor(u => u.Password, p => p.Random.String())
                .RuleFor(u => u.Email, p => p.Random.Replace("*******@gmail.com"))
                .RuleFor(u => u.Username, p => p.Person.Avatar)
                .Generate(capcity);
    }
}
