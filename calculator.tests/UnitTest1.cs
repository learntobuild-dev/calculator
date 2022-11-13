using calculator;
using NUnit.Framework;

namespace calculator.tests;

public class Tests
{
    [Test]
    public void Add()
    {
        Assert.AreEqual(2, Program.Evaluate("1+1"));
    }

    [Test]
    public void AddSubtract()
    {
        Assert.AreEqual(2, Program.Evaluate("1+1-1+1"));
    }

    [Test]
    public void MultipleAdd()
    {
        Assert.AreEqual(3, Program.Evaluate("1+1+1"));
    }
    
    [Test]
    public void Subtract()
    {
        Assert.AreEqual(1, Program.Evaluate("3-2"));
    }

    [Test]
    public void AddAndSubtract()
    {
        Assert.AreEqual(2, Program.Evaluate("3-2+1"));
    }

    [Test]
    public void Subtract2()
    {
        Assert.AreEqual(5, Program.Evaluate("10-2-3"));
    }

    [Test]
    public void Subtract3()
    {
        Assert.AreEqual(7, Program.Evaluate("10-2-1"));
    }
}