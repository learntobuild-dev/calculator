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
}