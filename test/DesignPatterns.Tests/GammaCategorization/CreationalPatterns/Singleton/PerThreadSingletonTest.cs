using DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.PerThreadSingleton;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Singleton;

public class PerThreadSingletonTest
{
    [Fact]
    public void InstanceIds_AreEqual_PerThread()
    {
        int id = 0, id1, id2;
        var t1 = Task.Factory.StartNew(() => id = PerThreadSingleton.Instance.Id);
        var t2 = Task.Factory.StartNew(() =>
        {
            id1 = PerThreadSingleton.Instance.Id;
            id2 = PerThreadSingleton.Instance.Id;
            
            Assert.Equal(id1, id2);
            Assert.NotEqual(id, id1);
        });
        Task.WhenAll(t1, t2);
    }
}