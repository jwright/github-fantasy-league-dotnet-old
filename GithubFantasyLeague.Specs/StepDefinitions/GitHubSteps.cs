using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using GitHubFantasyLeauge.Specs.Support;
using WatiN.Core;
using GithubFantasyLeague.Model;
using NUnit.Framework;

namespace GitHubFantasyLeauge.Specs.StepDefinitions
{
    [Binding]
    public class GitHubSteps
    {
        private string _username = string.Empty;

        [Given(@"I have a valid github username")]
        public void GivenIHaveAValidGithubUsername()
        {
            _username = "tenderlove";
        }

        [When(@"I enter the Github username")]
        public void WhenIEnterTheGithubUsername()
        {
            Engine.Current.Browser.TextFields.First(Find.ByLabelText("Username")).Value = _username;
            Engine.Current.Browser.Link(Find.ByText("Get scores")).Click();
        }

        [Then(@"I should see the total score")]
        public void ThenIShouldSeeTheTotalScore()
        {
            var totalScore = User.Find(_username).Calculate().TotalScore;
            Assert.AreEqual(Engine.Current.Browser.Span(Find.ById("total-score")).Text, totalScore);
        }

    }
}
