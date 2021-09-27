﻿using SList.Domain.Factories;
using SList.Domain.Models;
using SList.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories
{
    public class UserRepository : IUserRepository
    {
        private SListContextFactory _contextFactory;

        public UserRepository(SListContextFactory factory)
        {
            _contextFactory = factory;
        }
        public void Add(
            string username,
            string email,
            string firstName,
            string lastName,
            string password,
            DateTime createdAt,
            DateTime? updatedAt)
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                ctx.Add(new User 
                {
                    Username = username,
                    CreatedAt = createdAt,
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    UpdatedAt = updatedAt
                });
                ctx.SaveChanges();
            };
        }

        public User Get(string username, string password)
        {
            using var ctx = _contextFactory.CreateDbContext();

            return ctx
                .Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();
        }
        public User Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
