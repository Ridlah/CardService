using CardService.Model;
using Microsoft.AspNetCore.Mvc;

namespace CardService.Controllers;

[ApiController]
[Route("Card")]
public class CardController : ControllerBase
{
    [HttpGet]
    public Card Get()
    {
        return new Card { Suite = "Spade", Rank = "Ace" };
    }
}