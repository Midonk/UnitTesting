using System;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Geometries.Runtime;

public class Geometry_ex04_Test
{
    #region Tests
    [SetUp]
    public void SetUpTests()
    {
        _smallBox = new Geometry_ex04(0.6f);
        _normalBox = new Geometry_ex04(0.64f);
        _bigBox = new Geometry_ex04(0.7f);
        _expected = 0.64f * 0.64f * 6; 
    }

    [Test]
    public void Geometry_ex04_TestSmallBox()
    {
        var result = _smallBox.ComputeSurface();
        
        Assert.AreNotEqual(_expected, result, "BOUM! WOAH!");
    }

    [Test]
    public void Geometry_ex04_TestNormalBox()
    {
        var result = _normalBox.ComputeSurface();
        
        Assert.AreEqual(_expected, result, "BOUM! WOAH!");
    }

    [Test]
    public void Geometry_ex04_TestBigBox()
    {
        var result = _bigBox.ComputeSurface();
        
        Assert.AreNotEqual(_expected, result, "BOUM! WOAH!");
    }

    [TearDown]
    public void TearDownTests()
    {
        _smallBox = null;
        _normalBox = null;
        _bigBox = null;

        _expected = 0.0f;
    }

    #endregion


    #region Private
    private float _expected;
    private Geometry_ex04 _smallBox;
    private Geometry_ex04 _normalBox;
    private Geometry_ex04 _bigBox;
    
    #endregion
}
