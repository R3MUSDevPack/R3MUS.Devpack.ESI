﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3MUS.Devpack.ESI.Models.Corporation;

namespace R3MUS.Devpack.ESI.Tests.CorpTests
{
    [TestClass]
    public class CorpExtTests
    {
        [TestMethod]
        public void GetCorp_ReturnValid()
        {
            //  Arrange
            var corpId = Properties.Settings.Default.CorporationId;

            //  Act
            var corpResponse = new Detail(corpId);

            //  Assert
            corpResponse.Should().NotBeNull();
        }
    }
}
