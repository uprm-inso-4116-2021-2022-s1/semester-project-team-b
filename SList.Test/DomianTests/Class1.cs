using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SList.Test.DomianTests
{
    public class Quereies
    {
        [Fact]
        public void Q1()
        {
            using (var ctx = new SListContext()) 
            {
                User user = new User
                {
                    FirstName = "Kemuel",
                    LastName = "Torres",
                    Password = "###$%##$#$",
                    Username = "Kelminator",
                    Email = "kemuel.torres1@upr.edu",
                };
                ctx.Add(user);
                ctx.SaveChanges();
                Assert.True(ctx.Users.Any());
            };
            

        }
    }
}
