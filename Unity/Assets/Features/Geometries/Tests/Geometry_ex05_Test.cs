using NUnit.Framework;
using Geometries.Runtime;

public class Geometry_ex05_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _smallHitbox = new Geometry_ex05(0.99f);
        _bigHitbox = new Geometry_ex05(1.04f);
    }

    [Test]
    public void Geometry_ex05_TestTwoSmall()
    {
        var result = _smallHitbox.IsCollidingWith(_smallHitbox);

        Assert.IsFalse(result, "Une déformation de l'espace a tué les deux carrés");
    }

    [Test]
    public void Geometry_ex05_TestSmallBig()
    {
        var result = _smallHitbox.IsCollidingWith(_bigHitbox);

        Assert.IsTrue(result, "Une déformation de l'espace a sauvé les deux carrés");
    }

    [Test]
    public void Geometry_ex05_TestBigSmall()
    {
        var result = _bigHitbox.IsCollidingWith(_smallHitbox);

        Assert.IsTrue(result, "Une déformation de l'espace a sauvé les deux carrés");
    }

    [Test]
    public void Geometry_ex05_TestTwoBig()
    {
        var result = _bigHitbox.IsCollidingWith(_bigHitbox);

        Assert.IsTrue(result, "Une déformation de l'espace a sauvé les deux carrés");
    }

    [TearDown]
    public void TearDownTests()
    {
        _smallHitbox = null;
        _bigHitbox = null;
    }

    #endregion

    
    #region Private
    private Geometry_ex05 _smallHitbox;
    private Geometry_ex05 _bigHitbox;
    
    #endregion
}
