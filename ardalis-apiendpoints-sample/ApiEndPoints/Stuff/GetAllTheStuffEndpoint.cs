using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using ardalis_apiendpoints_sample.Services;
using ardalis_apiendpoints_sample.Models;

namespace ardalis_apiendpoints_sample.ApiEndPoints.Stuff
{
  public class GetAllTheStuffEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<List<StuffyStuff>>
  {
    private readonly IStuffService stuffService;

    public GetAllTheStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    [HttpGet("stuffystuff/")]
    public override async Task<ActionResult<List<StuffyStuff>>> HandleAsync(CancellationToken cancellationToken = default)
    {
      var allthestuff = stuffService.GetAllTheStuff();
      return Ok(allthestuff);
    }

  }
}
