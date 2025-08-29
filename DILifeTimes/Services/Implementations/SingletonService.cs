using DILifeTimes.Services.Interfaces;

namespace DILifeTimes.Services.Implementations;

public class SingletonService : ISingletonService
{
    private Guid _id;

    public SingletonService()
    {
        _id =  Guid.NewGuid();
    }
    public string GetGuid()
    {
       
        return _id.ToString();
    }
}