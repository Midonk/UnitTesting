using NUnit.Framework;
using UnityEngine;
using Geometries.Runtime;

public class Geometry_ex10_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _squareSizes = new float[]{5.0f, 3.0f, 2.5f};
        _circleRadiuses = new float[]{2.5f, Mathf.Sqrt(18.0f)/2, 3.5f};
    }

    [Test]
    public void Geometry_ex10_TestCircleWithinSquare()
    {
        var result = Geometry_ex10.CircleWithinSquare(_squareSizes[0], _circleRadiuses[0]);

        Assert.AreEqual(+1, result);
    }

    [Test]
    public void Geometry_ex10_TestSquareWithinCircle()
    {
        var result = Geometry_ex10.CircleWithinSquare(_squareSizes[1], _circleRadiuses[1]);

        Assert.AreEqual(-1, result);
    }

    [Test]
    public void Geometry_ex10_TestNeither()
    {
        var result = Geometry_ex10.CircleWithinSquare(_squareSizes[2], _circleRadiuses[2]);

        Assert.AreEqual(0, result);
    }

    [TearDown]
    public void TearDownTests()
    {
        _squareSizes = null;
        _circleRadiuses = null;
    }

    #endregion
    

    #region Private

    private float[] _squareSizes;
    private float[] _circleRadiuses;
    
    #endregion
}
