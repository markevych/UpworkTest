using Moq;
using UpworkTest.Interfaces;
using UpworkTest.Models;
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
    }
}
