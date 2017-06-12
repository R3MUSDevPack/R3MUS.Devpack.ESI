using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3MUS.Devpack.ESI.Extensions;
using FluentAssertions;
using Ploeh.AutoFixture;
using Moq;
using R3MUS.Devpack.ESI.Models.Alliance;
using System.Linq;
using R3MUS.Devpack.ESI.Models.Shared;

namespace R3MUS.Devpack.ESI.Tests.AllianceTests
{
    [TestClass]
    public class AllianceExtTests : TestBase
    {
        [TestMethod]
        public void GetAlliances_ReturnsListOfInt()
        {
            //  Act
            var result = new Detail().GetAlliances();

            //  Assert
            result.Ids.Count.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void GetAlliances_ReturnsListOfString()
        {
            //  Arrange
            var allianceIds = new Detail().GetAlliances().Ids.Take(3).ToList();
            var alliances = new IdList() { Ids = allianceIds };

            //  Act
            var result = alliances.GetAllianceNames();

            //  Assert
            result.AllianceDetail.Count().Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void GetAlliance_ReturnValid()
        {
            //  Arrange
            var allianceId = new Detail().GetAlliances().Ids.First();
            //  Act
            var allianceResponse = new Detail(allianceId);

            //  Assert
            allianceResponse.Should().NotBeNull();
        }        
    }
}
