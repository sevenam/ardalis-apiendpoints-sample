using Ardalis.ApiEndpoints;
using ardalis_apiendpoints_sample.Models;
using ardalis_apiendpoints_sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ardalis_apiendpoints_sample.ApiEndPoints.Stuff
{
  public class AddStuffEndpoint : EndpointBaseAsync.WithRequest<StuffyStuff>.WithActionResult<bool>
  {
    private readonly IStuffService stuffService;

    public AddStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    [HttpPost("stuffystuff/")]
    public override async Task<ActionResult<bool>> HandleAsync(StuffyStuff stuff, CancellationToken cancellationToken = default)
    {
      var result = stuffService.AddStuff(stuff);
      return Ok(result);
    }

  }
}
