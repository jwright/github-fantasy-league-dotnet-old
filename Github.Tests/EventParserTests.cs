using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Github.Tests
{
    [TestFixture]
    public class EventParserTests
    {
        [Test]
        public void Test_Get_returns_data_for_valid_username()
        {
            var parser = new EventParser("ry");
            Assert.IsNotNull(parser.Get().First().Type);
        }
    }
}
