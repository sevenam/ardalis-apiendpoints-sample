using ardalis_apiendpoints_sample.Models;

namespace ardalis_apiendpoints_sample.Services
{
  public class StuffService : IStuffService
  {
    private List<StuffyStuff> listOfStuff;

    public StuffService()
    {
      listOfStuff = new List<StuffyStuff>();
    }

    public List<StuffyStuff> GetAllTheStuff()
    {
      return listOfStuff;
    }

    public StuffyStuff GetStuffById(Guid id)
    {
      var singlestuff = listOfStuff.SingleOrDefault(x => x.Id.Equals(id));
      return singlestuff;
    }

    public bool AddStuff(StuffyStuff stuff)
    {
      listOfStuff.Add(stuff);
      return true;
    }

    public bool RemoveStuff(Guid id)
    {
      var result = listOfStuff.Remove(listOfStuff.Single(x => x.Id.Equals(id)));
      return result;
    }


  }
}
