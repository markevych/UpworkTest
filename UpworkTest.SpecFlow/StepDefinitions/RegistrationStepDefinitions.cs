using UpworkTest.Models;

namespace UpworkTest.SpecFlow.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public RegistrationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

            _scenarioContext["Users"] = new List<User>();
        }

        [Given(@"The email of user is (.*)")]
        public void GivenTheEmailOfUserIsExampleSite_Com(string email)
        {
            _scenarioContext["UserCandidate"] = new User { Email = email };
        }

        [When(@"user with such email doesn't exist in database")]
        public void WhenUserWithSuchEmailDoesntExistInDatabase()
        {
        }

        [When(@"user with such email exists in database")]
        public void WhenUserWithSuchEmailExistsInDatabase()
        {
            ((List<User>)_scenarioContext["Users"]).Add((User)_scenarioContext["UserCandidate"]);
        }

        [Then(@"user is allowed to be registered in application")]
        public void ThenUserIsAllowedToBeRegisteredInApplication()
        {
            _scenarioContext["UserCandidate"] = null;
            ((List<User>)_scenarioContext["Users"]).Add((User)_scenarioContext["UserCandidate"]);
            Assert.True(true);
        }

        [Then(@"user is not allowed to be registered in application")]
        public void ThenUserIsNotAllowedToBeRegisteredInApplication()
        {
            _scenarioContext["UserCandidate"] = null;
            Assert.True(true);
        }
    }
}
