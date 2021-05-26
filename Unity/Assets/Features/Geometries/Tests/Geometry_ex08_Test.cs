using NUnit.Framework;
using UnityEngine;
using Geometries.Runtime;

public class Geometry_ex08_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _vectorA = new Vector2(3.0f, 1.5f);
        _vectorB = new Vector2(0.0f, 2.5f);
        _vectorC = new Vector2(-5.2f, 1.3f);
    }

    [Test]
    public void Geometry_ex08_TestAB()
    {
        var result = Geometry_ex08.ComputeAngle(_vectorA, _vectorB);
        var expected = Vector2.Angle(_vectorA, _vectorB);

        Assert.IsTrue(Mathf.Approximately(result, expected));
    }

    [Test]
    public void Geometry_ex08_TestBC()
    {
        var result = Geometry_ex08.ComputeAngle(_vectorB, _vectorC);
        var expected = Vector2.Angle(_vectorB, _vectorC);

        Assert.IsTrue(Mathf.Approximately(result, expected));
    }

    [Test]
    public void Geometry_ex08_TestAC()
    {
        var result = Geometry_ex08.ComputeAngle(_vectorA, _vectorC);
        var expected = Vector2.Angle(_vectorA, _vectorC);

        Assert.IsTrue(Mathf.Approximately(result, expected));
    }

    [TearDown]
    public void TearDownTests()
    {
        _vectorA = Vector2.zero;
        _vectorB = Vector2.zero;
        _vectorC = Vector2.zero;
    }

    #endregion
    

    #region Private
    private Vector2 _vectorA;
    private Vector2 _vectorB;
    private Vector2 _vectorC;
    
    #endregion
}
