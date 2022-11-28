using ardalis_apiendpoints_sample.Models;

namespace ardalis_apiendpoints_sample.Services
{
    public interface IStuffService
    {
      List<Stuff> GetAllTheStuff();
      Stuff GetStuffById(Guid id);
      bool AddStuff(Stuff stuff);
       bool RemoveStuff(Guid id);
    }
}
