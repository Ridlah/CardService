using NUnit.Framework;

namespace CardService.Tests.Controllers;

public class CardController
{
    [Test]
    public void Test1()
    {
        // Assign
        var cardController = new CardService.Controllers.CardController();

        // Act
        var result = cardController.Get();

        // Assert
        Assert.AreEqual("Ace", result.Rank);
    }
}