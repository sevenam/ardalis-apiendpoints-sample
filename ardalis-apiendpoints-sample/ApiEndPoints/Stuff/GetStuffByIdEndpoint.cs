using Ardalis.ApiEndpoints;
using ardalis_apiendpoints_sample.Models;
using ardalis_apiendpoints_sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ardalis_apiendpoints_sample.ApiEndPoints.Stuff
{
  public class GetStuffByIdEndpoint : EndpointBaseAsync.WithRequest<Guid>.WithActionResult<StuffyStuff>
  {
    private readonly IStuffService stuffService;

    public GetStuffByIdEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    [HttpGet("stuffystuff/{id}")]
    public override async Task<ActionResult<StuffyStuff>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
    {
      var stuff = stuffService.GetStuffById(id);
      return Ok(stuff);
    }


  }
}
