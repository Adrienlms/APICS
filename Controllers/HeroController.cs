using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HeroController : ControllerBase
{

    private static List<Hero> heroes = new List<Hero>
    {
        new Hero{ Id = 1 , Name = "Batman", Power = "Money", Weakness = "Joker", Universe = "DC", Image = "https://i.pinimg.com/originals/0d/0d/0d/0d0d0d0d0d0d0d0d0d0d0d0d0d0d0d0d.jpg" }
    };

    public ActionResult<List<Hero>> Get()
    {
        return Ok(heroes);
    }

    [HttpPost]
    public ActionResult<Hero> Post(Hero hero)
    {
        heroes.Add(hero);
        return Ok(hero);
    }
}
