using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace GitHubFantasyLeauge.Specs.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
