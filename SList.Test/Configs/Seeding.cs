using Bogus;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using SList.Domain.Models;
using SList.Infrastructure.Context;
using SList.Infrastructure.Factories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Test.Configs
{
    public class Seeding
    {
        private readonly SListContextFactory _contextFactory;
        public SListContext BuildContext() => _contextFactory.BuildContext(
            new DbContextOptionsBuilder<SListContext>()
                .UseSqlServer("Server=localhost;Database=SList;Trusted_Connection=True;"));//TODO: get it to read from a config file
        public Seeding() 
        {
            _contextFactory = new SListContextFactory(null);
        }
        public SListContextFactory GetFactory() => _contextFactory;
        public void Populate()
        {
            using var ctx = BuildContext();
            ctx.AddRange(GenerateUsers(100));
            ctx.SaveChanges();

        }
        private List<User> GenerateUsers(int size) => new Faker<User>()
            .RuleFor(u => u.Username, f => f.Person.UserName)
            .RuleFor(u => u.Email, f => f.Person.Email)
            .RuleFor(u => u.Password, f => f.Random.Replace("*************"))
            .RuleFor(u => u.FirstName, f => f.Person.FirstName)
            .RuleFor(u => u.LastName, f => f.Person.LastName)
            .Generate(size);
    }
}
