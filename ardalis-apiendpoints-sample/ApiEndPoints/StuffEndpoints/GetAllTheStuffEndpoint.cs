using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using ardalis_apiendpoints_sample.Services;
using ardalis_apiendpoints_sample.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace ardalis_apiendpoints_sample.ApiEndPoints.StuffEndpoints
{
  public class GetAllTheStuffEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<List<Stuff>>
  {
    private readonly IStuffService stuffService;

    public GetAllTheStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    [HttpGet("stuffystuff/")]
    [SwaggerOperation(Summary = "Gets all of the stuff", Description = "ApiEndPoints - Get all the stuff", OperationId = "Stuff.GetAlltheStuff", Tags = new[] { "StuffApiEndpoints" })]
    public override async Task<ActionResult<List<Stuff>>> HandleAsync(CancellationToken cancellationToken = default)
    {
      var allthestuff = stuffService.GetAllTheStuff();
      return Ok(allthestuff);
    }

  }
}
