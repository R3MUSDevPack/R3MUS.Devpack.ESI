using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3MUS.Devpack.ESI.Extensions;
using R3MUS.Devpack.ESI.Models;
using R3MUS.Devpack.ESI.Models.Wars;
using System.Linq;

namespace R3MUS.Devpack.ESI.Tests.WarTests
{
	[TestClass]
	public class WarExtTests
	{
		[TestMethod]
		public void GetWarIds_ReturnsValid()
		{
			//	Act
			var result = War.GetWarIds();

			//	Assert
			result.Count.Should().BeGreaterOrEqualTo(0);
		}

		[TestMethod]
		public void GetWar_ReturnsValid()
		{
			//	Arrange
			var warId = War.GetWarIds().First();

			 //	Act
			var result = new War(warId);

			//	Assert
			result.Should().NotBeNull();
		}
	}
}
