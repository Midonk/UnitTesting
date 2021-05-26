using NUnit.Framework;
using Geometries.Runtime;

public class Geometry_ex06_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _smallSphere = new Geometry_ex06(0.5f);
        _bigSphere = new Geometry_ex06(1.0f);
    }

    [Test]
    public void Geometry_ex06_TestTwoSmall()
    {
        var result = _smallSphere.IsCollidingWith(_smallSphere);

        Assert.IsFalse(result, "Une déformation de l'espace a tué les deux sphères");
    }

    [Test]
    public void Geometry_ex06_TestSmallBig()
    {
        var result = _smallSphere.IsCollidingWith(_bigSphere);

        Assert.IsFalse(result, "Une déformation de l'espace a tué les deux sphères");
    }

    [Test]
    public void Geometry_ex06_TestBigSmall()
    {
        var result = _bigSphere.IsCollidingWith(_smallSphere);

        Assert.IsFalse(result, "Une déformation de l'espace a tué les deux sphères");
    }

    [Test]
    public void Geometry_ex06_TestTwoBig()
    {
        var result = _bigSphere.IsCollidingWith(_bigSphere);

        Assert.IsTrue(result, "Une déformation de l'espace a sauvé les deux sphères");
    }

    [TearDown]
    public void TearDownTests()
    {
        _smallSphere = null;
        _bigSphere = null;
    }

    #endregion
    

    #region Private
    private Geometry_ex06 _smallSphere;
    private Geometry_ex06 _bigSphere;
    
    #endregion
}
