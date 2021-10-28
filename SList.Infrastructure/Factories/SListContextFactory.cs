using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SList.Infrastructure.Context;

namespace SList.Infrastructure.Factories
{
    public class SListContextFactory : IDbContextFactory<SListContext>
    {
        private ILoggerFactory _loggerFactory;
        public SListContextFactory(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public SListContext CreateDbContext()
        {
            var optionBuilder = new DbContextOptionsBuilder<SListContext>();
            optionBuilder.UseLoggerFactory(_loggerFactory)
                .EnableSensitiveDataLogging(true);
            return new SListContext(optionBuilder.Options);

        }
    }
}
