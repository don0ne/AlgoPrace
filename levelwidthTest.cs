using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class TreeAnalysisTests
{
    [Test]
    public void LevelWidth_WithNullRoot_ReturnsEmptyList()
    {
        var result = TreeAnalysis.LevelWidth(null);
        Assert.IsEmpty(result);
    }

    [Test]
    public void LevelWidth_WithSingleNode_ReturnsCorrectWidth()
    {
        var root = new Node(1);
        var result = TreeAnalysis.LevelWidth(root);
        var expected = new List<int> { 1 };
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void LevelWidth_WithMultipleLevels_ReturnsCorrectWidths()
    {
        var root = new Node(1);
        root.Add(2);
        root.Add(3);
        root.Children[0].Add(4);
        root.Children[0].Add(5);
        root.Children[1].Add(6);

        var result = TreeAnalysis.LevelWidth(root);
        var expected = new List<int> { 1, 2, 3 };
        Assert.AreEqual(expected, result);
    }
}
