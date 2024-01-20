using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FibonacciTests
{
    [TestMethod]
    public void Fib_With0_ShouldReturn0()
    {
        Assert.AreEqual(0, Fibonacci.Fib(0));
    }

    [TestMethod]
    public void Fib_With1_ShouldReturn1()
    {
        Assert.AreEqual(1, Fibonacci.Fib(1));
    }

    [TestMethod]
    public void Fib_With2_ShouldReturn1()
    {
        Assert.AreEqual(1, Fibonacci.Fib(2));
    }

    [TestMethod]
    public void Fib_With3_ShouldReturn2()
    {
        Assert.AreEqual(2, Fibonacci.Fib(3));
    }

    [TestMethod]
    public void Fib_With4_ShouldReturn3()
    {
        Assert.AreEqual(3, Fibonacci.Fib(4));
    }

}
