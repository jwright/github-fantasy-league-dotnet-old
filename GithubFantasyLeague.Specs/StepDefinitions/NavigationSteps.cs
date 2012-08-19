using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using GitHubFantasyLeauge.Specs.Support;

namespace GitHubFantasyLeauge.Specs.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Engine.Current.Browser.GoTo("http://localhost/gh/");
        }
    }
}
