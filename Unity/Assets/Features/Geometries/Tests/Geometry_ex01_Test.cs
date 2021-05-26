using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Geometries.Runtime;

public class Geometry_ex01_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _shapeLine = new Geometry_ex01(1.0f, 0.0f);
        _shapeRectangleHigh = new Geometry_ex01(1.0f, 2.0f);
        _shapeRectangleWide = new Geometry_ex01(2.0f, 1.0f);
        _shapeSquare = new Geometry_ex01(1.0f, 1.0f);
    }

    [Test]
    public void Geometry_ex01_TestLine()
    {
        var result = _shapeLine.IsSquare();

        Assert.IsFalse(result, "D'après vous, une ligne est un carré?");
    }

    [Test]
    public void Geometry_ex01_TestRectangleHigh()
    {
        var result = _shapeRectangleHigh.IsSquare();

        Assert.IsFalse(result, "D'après vous, un rectangle de 1m x 2m est un carré?");
    }

    [Test]
    public void Geometry_ex01_TestRectangleWide()
    {
        var result = _shapeRectangleWide.IsSquare();

        Assert.IsFalse(result, "D'après vous, un rectangle de 2m x 1m est un carré?");
    }

    [Test]
    public void Geometry_ex01_TestSquare()
    {
        var result = _shapeSquare.IsSquare();

        Assert.IsTrue(result, "D'après vous, un rectangle de 1m x 1m n'est pas un carré?");
    }

    [TearDown]
    public void TearDownTests()
    {
        _shapeLine = null;
        _shapeRectangleHigh = null;
        _shapeRectangleWide = null;
        _shapeSquare = null;
    }

    #endregion
    

    #region Private
    private Geometry_ex01 _shapeSquare;
    private Geometry_ex01 _shapeRectangleHigh;
    private Geometry_ex01 _shapeRectangleWide;
    private Geometry_ex01 _shapeLine;

    #endregion
}
