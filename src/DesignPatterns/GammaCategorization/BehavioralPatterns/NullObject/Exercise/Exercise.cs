namespace DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject.Exercise;

public interface ILog
{
    // maximum # of elements in the log
    int RecordLimit { get; }
    
    // number of elements already in the log
    int RecordCount { get; set; }

    // expected to increment RecordCount
    void LogInfo(string message);
}

public class Account
{
    private readonly ILog _log;

    public Account(ILog log)
    {
        _log = log;
    }

    public void SomeOperation()
    {
        var c = _log.RecordCount;
        _log.LogInfo("Performing an operation");
        if (c + 1 != _log.RecordCount)
        {
            throw new Exception();
        }
        if (_log.RecordCount >= _log.RecordLimit)
        {
            throw new Exception();
        }
    }
}

public class NullLog : ILog
{
    public int RecordLimit => int.MaxValue;
    public int RecordCount { get; set; }
    public void LogInfo(string message)
    {
        RecordCount++;
    }
}