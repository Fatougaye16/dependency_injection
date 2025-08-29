using DILifeTimes.Services.Interfaces;

namespace DILifeTimes.Services.Implementations;

public class TransientService : ITransientService
{
    private Guid _id;

    public TransientService()
    {
        _id =  Guid.NewGuid();

    }
    public string GetGuid()
    {
        return _id.ToString();
    }
}