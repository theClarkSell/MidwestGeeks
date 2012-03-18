using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MidwestGeeks.Lib;

namespace MidwestGeeks.Tests
{
    [TestFixture]
    public class NoTests
    {
        [Test]
        public void EventBriteApiTest()
        {
            var angleBracketEvents = new AngleBracketEventRepo();

            var results = angleBracketEvents.ListEvents();

            Assert.IsNotEmpty(results);
        }
    }
}
