using System;
using System.Collections.Generic;
using System.Linq;
using Github;

namespace GithubFantasyLeague.Model
{
    public class User
    {
        private string _username;
        private int _totalScore;
        private GithubScorer _scorer;

        public int TotalScore
        {
            get { return _totalScore; }
        }

        private GithubScorer Scorer
        {
            get
            {
                if (_scorer == null)
                {
                    var data = new EventParser(_username).Get();
                    _scorer = new GithubScorer(data).Score();
                }
                return _scorer;
            }
        }

        private User(string username) 
        {
            _username = username;
        }

        public static User Find(string username)
        {
            return new User(username);
        }

        public User Calculate()
        {
            _totalScore = Scorer.TotalScore;
            return this;
        }
    }
}
