using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3MUS.Devpack.ESI.Models.Character;

namespace R3MUS.Devpack.ESI.Tests.ToonTests
{
	[TestClass]
	public class CharacterExtTests
	{
		[TestMethod]
		public void GetCharacter_ReturnValid()
		{
			//  Arrange
			var toonId = 93902200;
			//  Act
			var toonResponse = new Detail(toonId);

			//  Assert
			toonResponse.Should().NotBeNull();
		}
	}
}
