using Ardalis.ApiEndpoints;
using ardalis_apiendpoints_sample.Models;
using ardalis_apiendpoints_sample.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ardalis_apiendpoints_sample.ApiEndPoints.Stuff
{
  public class DeleteStuffEndpoint : EndpointBaseAsync.WithRequest<Guid>.WithActionResult<bool>
  {
    private readonly IStuffService stuffService;

    public DeleteStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    [HttpDelete("stuffystuff/{id}")]
    [SwaggerOperation(Summary = "Deletes stuff", Description = "ApiEndPoints - Delete stuff", OperationId = "Stuff.DeleteStuff", Tags = new[] { "StuffApiEndpoints" })]
    public override async Task<ActionResult<bool>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
    {
      var result = stuffService.RemoveStuff(id);
      return Ok(result);
    }
  }
}
