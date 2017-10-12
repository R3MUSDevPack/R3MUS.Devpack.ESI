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
	}
}
