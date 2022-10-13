namespace DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject.Singleton;

public interface ILog
{
    void Info(string msg);
    void Warn(string msg);
    
    public static ILog Null => NullLog.Instance;
    
    private sealed class NullLog : ILog
    {
        private NullLog()
        {
        }

        private static readonly Lazy<NullLog> _instance = new(() => new NullLog());
        public static ILog Instance => _instance.Value;

        public void Info(string msg)
        {
        }

        public void Warn(string msg)
        {
        }
    }
}