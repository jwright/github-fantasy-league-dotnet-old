using System;
using System.Collections.Generic;
using System.Linq;

namespace GithubFantasyLeague.Model
{
    public class User
    {
        private int _totalScore;

        public int TotalScore
        {
            get { return _totalScore; }
        }

        private User() { }

        public static User Find(string username)
        {
            throw new NotImplementedException();
        }

        public User Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
