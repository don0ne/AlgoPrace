using NUnit.Framework;

[TestFixture]
public class VowelsCounterTests
{
    [Test]
    public void CountVowels_WithMixedCase_ReturnsCorrectCount()
    {
        Assert.AreEqual(3, VowelsCounter.CountVowels("Hi There!"));
        Assert.AreEqual(4, VowelsCounter.CountVowels("Why do you ask?"));
        Assert.AreEqual(0, VowelsCounter.CountVowels("Why?"));
        Assert.AreEqual(5, VowelsCounter.CountVowels("aeiou"));
        Assert.AreEqual(5, VowelsCounter.CountVowels("AEIOU"));
        Assert.AreEqual(5, VowelsCounter.CountVowels("abcdefghijklmnopqrstuvwxyz"));
        Assert.AreEqual(0, VowelsCounter.CountVowels("bcdfghjkl"));
    }
}
