using ardalis_apiendpoints_sample.Models;

namespace ardalis_apiendpoints_sample.Services
{
    public interface IStuffService
    {
      List<StuffyStuff> GetAllTheStuff();
      StuffyStuff GetStuffById(Guid id);
      bool AddStuff(StuffyStuff stuff);
       bool RemoveStuff(Guid id);
    }
}
