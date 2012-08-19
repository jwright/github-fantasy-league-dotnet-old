using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace GithubFantasyLeague.Model.Tests
{    
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Test_Calculate_calculates_the_total_score()
        {
            var user = User.Find("tenderlove");
            Assert.IsTrue(user.Calculate().TotalScore > 0);
        }
    }
}
