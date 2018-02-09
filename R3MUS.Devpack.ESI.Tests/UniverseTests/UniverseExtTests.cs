using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3MUS.Devpack.ESI.Models.Universe;
using R3MUS.Devpack.ESI.Extensions;
using FluentAssertions;

namespace R3MUS.Devpack.ESI.Tests.UniverseTests
{
	[TestClass]
	public class UniverseExtTests
	{
		[TestMethod]
		public void GetItemIds_ReturnsValid()
		{
			//	Act
			var result = new ItemType().GetItemIds();

			//	Assert
			result.Ids.Count.Should().BeGreaterOrEqualTo(0);
		}

		[TestMethod]
		public void GetItem_ReturnsValid()
		{
			//	Arrange
			var id = 0;

			//	Act
			var result = new ItemType(id);

			//	Assert
			result.Should().NotBeNull();
		}

        [TestMethod]
        public void GetStructure_ReturnsValid()
        {
            //  Arrange
            var authHeader = "D4p0LwiMrkqp8du72J7k-ypjZOcvos1ZvShi9DQkKRnRd7xX-J9XMI90RnWMMNu1wzOlGUpEGSsa3sKZBkW9Vg2";
            var structureId = 1023736622218;

            //  Act
            var result = new Structure(structureId, authHeader);

            //  Assert
            result.Should().NotBeNull();
        }
	}
}
