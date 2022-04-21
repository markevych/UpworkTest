using Microsoft.EntityFrameworkCore;
using System;
using ApplicationContext = UpworkTest.Context.Context;

namespace UpworkTest.XUnit.Context
{
    public class TestContext : IDisposable
    {
        public ApplicationContext Context { get; set; }

        public TestContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: $"{Guid.NewGuid()}")
                .Options;

            Context = new ApplicationContext(options);
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
