using ardalis_apiendpoints_sample.Models;
using ardalis_apiendpoints_sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ardalis_apiendpoints_sample.Controllers
{
  [ApiController]
  [Route("stuff")]
  public class StuffController : ControllerBase
  {
    private readonly IStuffService stuffService;

    public StuffController(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    [HttpGet]
    public IActionResult GetAllTheStuff()
    {
      var allofthestuff = stuffService.GetAllTheStuff();
      return Ok(allofthestuff);
    }

    [HttpGet("{id}")]
    public IActionResult GetStuffById([FromRoute]Guid id)
    {
      var stuff = stuffService.GetStuffById(id);
      return Ok(stuff);
    }

    [HttpPost]
    public IActionResult CreateStuff([FromBody] Stuff stuff)
    {
      var result = stuffService.AddStuff(stuff);
      return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStuff([FromRoute] Guid id)
    {
      var result = stuffService.RemoveStuff(id);
      return Ok(result);
    }

  }
}
