using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Github;

namespace GithubFantasyLeague.Model.Tests
{
    [TestFixture()]
    public class GithubScorerTests
    {
        private GithubScorer _scorer = null;

        [TestFixtureSetUp()]
        public void Run_before_all_tests()
        {
            var data = new List<Event>();
            data.Add(new Event { Type = "CommitCommentEvent" });
            data.Add(new Event { Type = "IssuesEvent" });
            data.Add(new Event { Type = "IssueCommentEvent" });
            data.Add(new Event { Type = "WatchEvent" });
            data.Add(new Event { Type = "PullRequestEvent" });
            data.Add(new Event { Type = "PushEvent" });
            data.Add(new Event { Type = "FollowEvent" });
            data.Add(new Event { Type = "CreateEvent" });

            _scorer = new GithubScorer(data);
        }

        [Test()]
        public void Test_Score_collects_the_events()
        {
            Assert.AreEqual(_scorer.Score().Events.Count(), 8);
        }

        [Test]
        public void Test_Score_calculates_the_total_score()
        {
            Assert.AreEqual(_scorer.Score().TotalScore, 24);
        }
    }
}
