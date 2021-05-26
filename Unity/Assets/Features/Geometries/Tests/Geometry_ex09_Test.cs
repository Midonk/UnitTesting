using NUnit.Framework;
using UnityEngine;
using Geometries.Runtime;

public class Geometry_ex09_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _vectorA = Vector2.right;
        _vectorB = new Vector2(1.0f, 1.0f);
        _vectorC = new Vector2(-0.5f, 1.5f);
    }

    [Test]
    public void Geometry_ex09_TestA()
    {
        var expected = Vector2.up;
        var result = Geometry_ex09.RotateVector(_vectorA, 90.0f);

        Assert.IsTrue(expected==result);
    }

    [Test]
    public void Geometry_ex09_TestB()
    {
        var radian = 45.0f * Mathf.Deg2Rad;
        var newX = _vectorB.x * Mathf.Cos(radian) - _vectorB.y * Mathf.Sin(radian);
        var newY = _vectorB.x * Mathf.Sin(radian) + _vectorB.y + Mathf.Cos(radian);

        var expected = new Vector2(newX, newY);
        var result = Geometry_ex09.RotateVector(_vectorB, 45.0f);

        Assert.IsTrue(expected==result);
    }
    
    [Test]
    public void Geometry_ex09_TestC()
    {
        var radian = 60.0f * Mathf.Deg2Rad;
        var newX = _vectorC.x * Mathf.Cos(radian) - _vectorC.y * Mathf.Sin(radian);
        var newY = _vectorC.x * Mathf.Sin(radian) + _vectorC.y + Mathf.Cos(radian);

        var expected = new Vector2(newX, newY);
        var result = Geometry_ex09.RotateVector(_vectorC, 60.0f);

        Assert.IsTrue(expected==result);
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
