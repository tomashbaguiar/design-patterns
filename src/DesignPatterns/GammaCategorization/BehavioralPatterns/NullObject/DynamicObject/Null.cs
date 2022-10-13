using System.Dynamic;
using ImpromptuInterface;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.NullObject.DynamicObject;

public class Null<TInterface> : System.Dynamic.DynamicObject where TInterface : class
{
    public static TInterface Instance => new Null<TInterface>().ActLike();

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        result = Activator.CreateInstance(binder.ReturnType);
        return true;
    }
}