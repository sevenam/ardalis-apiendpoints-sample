using Ardalis.ApiEndpoints;
using ardalis_apiendpoints_sample.Models;
using ardalis_apiendpoints_sample.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerOperation(Summary = "Gets stuff by id", Description = "ApiEndPoints - Get stuff by id", OperationId = "Stuff.GetStuffById", Tags = new[] { "StuffApiEndpoints" })]
    public override async Task<ActionResult<StuffyStuff>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
    {
      var stuff = stuffService.GetStuffById(id);
      return Ok(stuff);
    }


  }
}
