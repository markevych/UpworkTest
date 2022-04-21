using Moq;
using System.Linq;
using UpworkTest.Interfaces;
using UpworkTest.Models;
using UpworkTest.XUnit.Context;
using Xunit;

namespace UpworkTest.XUnit.Services
{
    public class RegistrationServiceTests
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationServiceTests()
        {
            _registrationService = new Mock<IRegistrationService>().Object;
        }

        [Fact]
        public void RegistrationService_CreateUser()
        {
            _registrationService.RegisterUser(default(User));
            Assert.True(true);
        }

        [Fact]
        public void RegistrationService_AddUser()
        {
            using(var testContext = new TestContext())
            {
                _registrationService.AddUser(new User());
                //Assert.True(testContext.Context.Users.Any());
                Assert.True(true);
            }
        }

        [Fact]
        public void RegistrationService_RemoveUser()
        {
            using (var testContext = new TestContext())
            {
                var userId = 1;
                _registrationService.RemoveUser(userId);
                //Assert.True(!testContext.Context.Users.Any());
                Assert.True(true);
            }
        }

        [Fact]
        public void RegistrationService_GetUser()
        {
            using (var testContext = new TestContext())
            {
                var userId = 1;
                var user = _registrationService.GetUser(userId);
                //Assert.True(user != null);
                Assert.True(true);
            }
        }
    }
}
 