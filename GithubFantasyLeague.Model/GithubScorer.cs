using System;
using System.Collections.Generic;
using System.Linq;
using Github;

namespace GithubFantasyLeague.Model
{
    public class GithubScorer
    {
        private IEnumerable<Event> _data;
        private IList<string> _events;
        private int _totalScore;

        public IList<string> Events
        {
            get { return _events; }
        }

        public int TotalScore
        {
            get { return _totalScore; }
        }

        public GithubScorer(IEnumerable<Event> data)
        {
            _data = data;
            Parse();
        }

        public GithubScorer Score()
        {
            _totalScore = 0;
            foreach (var @event in _events)
            {
                var score = 0;
                switch (@event)
                {
                    case "CommitCommentEvent":
                        score = 2;
                        break;
                    case "IssueCommentEvent":
                        score = 2;
                        break;
                    case "IssuesEvent":
                        score = 3;
                        break;
                    case "WatchEvent":
                        score = 1;
                        break;
                    case "PullRequestEvent":
                        score = 5;
                        break;
                    case "PushEvent":
                        score = 7;
                        break;
                    case "FollowEvent":
                        score = 1;
                        break;
                    case "CreateEvent":
                        score = 3;
                        break;
                }
                _totalScore += score;
            }
            return this;
        }

        private void Parse()
        {
            _events = new List<string>();
            foreach (var @event in _data)
                _events.Add(@event.Type);
        }
    }
}
