using DesignPatterns.GammaCategorization.StructuralPatterns.Composite.NeuralNetworks;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Composite;

public class NeuralNetworksTest
{
    [Fact]
    public void Test()
    {
        var neuron1 = new Neuron();
        var neuron2 = new Neuron();
        
        neuron1.ConnectTo(neuron2);

        var layer1 = new NeuronLayer();
        var layer2 = new NeuronLayer();
        layer1.ConnectTo(layer2);
    }
}