using System.Collections;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.NeuralNetworks;

public class Neuron : IEnumerable<Neuron>
{
    public float Value;
    public List<Neuron> In;
    public List<Neuron> Out;

    // public void ConnectTo(Neuron other)
    // {
    //     Out.Add(other);
    //     other.In.Add(this);
    // }

    public IEnumerator<Neuron> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}