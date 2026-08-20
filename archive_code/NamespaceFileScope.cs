/// Namespace file scope
/// Can only have 1 namespace in each file
namespace SampleNamespace;

class SampleClass
{
    public void SampleMethod()
    {
        System.Console.WriteLine("SampleMethod inside SampleNamespace");
    }
}

class AnotherSampleClass
{
    public void AnotherSampleMethod()
    {
        System.Console.WriteLine("AnotherSampleMethod inside SampleNamespace");
    }
}