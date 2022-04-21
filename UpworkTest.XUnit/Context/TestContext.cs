using System;
using ApplicationContext = UpworkTest.Context.Context;

namespace UpworkTest.XUnit.Context
{
    public class TestContext : IDisposable
    {
        public ApplicationContext Context { get; set; }

        public TestContext()
        {
            Context = new ApplicationContext();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
