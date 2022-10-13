namespace DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject;

public sealed class NullLog : ILog
{
    public void Info(string msg)
    {
    }

    public void Warn(string msg)
    {
    }
}