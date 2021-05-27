using NUnit.Framework;
using UnityEngine;
using Geometries.Runtime;

public class Geometry_ex02_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _Ganondorf = new Geometry_ex02(15.0f);
        _Link = new Geometry_ex02(10.0f);
        _Zelda = new Geometry_ex02(7.0f);
    }

    [Test]
    public void Geometry_ex02_TestGanondorf()
    {
        var result = _Ganondorf.ComputePerimeter();

        Assert.IsTrue(Mathf.Approximately(result, 15.0f));
    }

    [Test]
    public void Geometry_ex02_TestLink()
    {
        var result = _Link.ComputePerimeter();

        Assert.IsTrue(Mathf.Approximately(result, 10.0f));
    }

    [Test]
    public void Geometry_ex02_TestZelda()
    {
        var result = _Zelda.ComputePerimeter();

        Assert.IsTrue(Mathf.Approximately(result, 7.0f));
    }

    [TearDown]
    public void TearDownTests()
    {
        _Ganondorf = null;
        _Link = null;
        _Zelda = null;
    }

    #endregion
    

    #region Private
    private Geometry_ex02 _Ganondorf;
    private Geometry_ex02 _Link;
    private Geometry_ex02 _Zelda; 

    #endregion
}
