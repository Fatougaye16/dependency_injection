using DILifeTimes.Services.Interfaces;

namespace DILifeTimes.Services.Implementations;

public class ScopedService : IScopedService
{
    private Guid _id;

    public ScopedService()
    {
        _id = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return _id.ToString();
    }
}