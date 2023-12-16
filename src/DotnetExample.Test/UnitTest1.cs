namespace DotnetExample.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
       var myClass = new MyClass();
        Assert.That(myClass.ReturnsOne(), Is.EqualTo(1));
    }
}