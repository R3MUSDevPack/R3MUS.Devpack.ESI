using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI.Tests
{
    public class TestBase
    {
        public IFixture Fixture;

        [TestInitialize]
        public void TestInitialise()
        {
            Fixture = new Fixture();
        }
    }
}
